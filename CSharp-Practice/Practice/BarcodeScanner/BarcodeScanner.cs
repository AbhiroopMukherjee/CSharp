using System;
using System.Collections.Concurrent;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BarcodeScanner
{
    /// <summary>
    /// Implementation of the IBarcodeScanner
    /// </summary>
    public class BarcodeScanner : IBarcodeScanner
    {
        private const int Max_Message = 100;
        private const int DelayToReadBarcodeInMilliseconds = 500;
        private readonly StringBuilder _messages = new StringBuilder();

        private string _startDelimiter;
        private string _endDelimiter;
        private BlockingCollection<string> _fromDeviceQueue;
        private readonly CancellationTokenSource _cts;
        private bool _isConnected;
        private SerialPort _port;

        #region Events

        /// <inheritdoc />
        public string PortName => _port.PortName;

        /// <inheritdoc />
        public event EventHandler<string> BarcodeRead;

        /// <inheritdoc />
        public event Action<Exception> ErrorOccured;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="IBarcodeScanner"/> class.
        /// </summary>
        public BarcodeScanner()
        {
            _cts = new CancellationTokenSource();
            _port = new SerialPort();
            _isConnected = true;
        }

        /// <inheritdoc />
        public bool Disable()
        {
            try
            {
                ReleaseManagedResources();
                _isConnected = false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <inheritdoc />
        public void Enable(BarcodeSettings barcodeSettings)
        {
            try
            {
                _startDelimiter = barcodeSettings.StartDelimiter;
                _endDelimiter = barcodeSettings.EndDelimiter;

                if (_port.IsOpen)
                {
                    _port.Close();
                }

                OpenPort(barcodeSettings);
                _messages.Clear();
                _port.DataReceived += OnDataRecieved;
                _port.ErrorReceived += OnErrorRecieved;

                _fromDeviceQueue = new BlockingCollection<string>();

                new TaskFactory().StartNew(ReadFromDevice, _cts.Token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
            }
            catch
            {
                throw;
            }
        }

        private void ReadFromDevice()
        {
            try
            {
                while (_isConnected)
                {
                    try
                    {
                        var message = _fromDeviceQueue.Take(_cts.Token);

                        if (!string.IsNullOrEmpty(message))
                        {
                            BarcodeRead?.Invoke(this, message);
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorOccured?.Invoke(ex);
                    }
                    Task.Delay(DelayToReadBarcodeInMilliseconds);
                }
            }
            catch
            {
                throw;
            }
        }

        private void OnErrorRecieved(object sender, SerialErrorReceivedEventArgs e)
        {
            ErrorOccured?.Invoke(new Exception(e.ToString()));
        }

        private void OnDataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                var startDelimiterLength = _startDelimiter?.Length ?? 0;
                var endDelimiterLength = _endDelimiter?.Length ?? 0;
                while (_port.BytesToRead > 0)
                {
                    var data = _port.ReadByte();

                    _messages.Append((char)data);
                    if (IsStartDelimiter(startDelimiterLength))
                    {
                        _messages.Clear();
                    }
                    else if (IsEndDelimiter(endDelimiterLength))
                    {
                        _fromDeviceQueue.Add(_messages.ToString(0, _messages.Length - endDelimiterLength));
                        _messages.Clear();
                    }
                    else if (_messages.Length > Max_Message)
                    {
                        _messages.Clear();
                    }
                    else
                    {
                        // Deliberately empty.
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private bool IsEndDelimiter(int endDelimiterLength)
        {
            return _messages.Length >= endDelimiterLength &&
                                         _messages.ToString(_messages.Length - endDelimiterLength, endDelimiterLength) == _endDelimiter;
        }

        private bool IsStartDelimiter(int startDelimiterLength)
        {
            return startDelimiterLength > 0 &&
                                    _messages.Length >= startDelimiterLength &&
                                    _messages.ToString(_messages.Length - startDelimiterLength, startDelimiterLength) == _startDelimiter;
        }

        private void OpenPort(BarcodeSettings barcodeSettings)
        {
            try
            {
                _port = CreateSerialPort(barcodeSettings);
                _port.Open();
            }
            catch
            {
                throw;
            }
        }

        private SerialPort CreateSerialPort(BarcodeSettings barcodeSettings)
        {
            try
            {
                return new SerialPort
                {
                    PortName = barcodeSettings.ComPort,
                    BaudRate = barcodeSettings.BaudRate,
                    DataBits = barcodeSettings.DataBits,
                    StopBits = barcodeSettings.StopBits,
                    Parity = barcodeSettings.Parity
                };
            }
            catch
            {
                return null;
            }
        }

        protected void ReleaseManagedResources()
        {
            _port.DataReceived -= OnDataRecieved;
            _port.ErrorReceived -= OnErrorRecieved;
            _port.Close();
            _port.Dispose();
        }
    }
}
