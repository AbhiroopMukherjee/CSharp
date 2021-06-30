using System;

namespace BarcodeScanner
{
    /// <summary>
    /// Interface to read serial barcode scanner
    /// </summary>
    public interface IBarcodeScanner
    { 
        /// <summary>
        /// Gets the name of the serial port.
        /// </summary>
        public string PortName { get; }

        /// <summary>
        /// Enable the scanner based on configuration.
        /// </summary>
        void Enable(BarcodeSettings barcodeSettings);

        /// <summary>
        /// Disable the scanner.
        /// </summary>
        bool Disable();

        /// <summary>
        /// Raises when a barcode is read with the read string.
        /// </summary>
        event EventHandler<string> BarcodeRead;

        /// <summary>
        /// Raises when an error occurs.
        /// </summary>
        event Action<Exception> ErrorOccured;
    }
}
