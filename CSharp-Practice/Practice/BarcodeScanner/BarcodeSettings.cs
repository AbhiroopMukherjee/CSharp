using System.IO.Ports;

namespace BarcodeScanner
{
    /// <summary>
    /// Business class for Settings_Rd table
    /// </summary>
    public class BarcodeSettings
    {
        /// <summary>
        /// Gets or sets the name of a COM port.
        /// </summary>
        public string ComPort { get; set; }

        /// <summary>
        /// Gets or sets the Baud rate.
        /// </summary>
        public int BaudRate { get; set; }

        /// <summary>
        /// Gets or sets Data bits.
        /// </summary>
        public int DataBits { get; set; }

        /// <summary>
        /// Gets or sets Parity.
        /// </summary>
        public Parity Parity { get; set; }

        /// <summary>
        /// Gets or sets Stop bits.
        /// </summary>
        public StopBits StopBits { get; set; }

        /// <summary>
        /// Gets or sets Start delimiter.
        /// </summary>
        public string StartDelimiter { get; set; }

        /// <summary>
        /// Gets or sets End delimiter.
        /// </summary>
        public string EndDelimiter { get; set; }
        
    }
}
