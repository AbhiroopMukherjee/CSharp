using AForge.Video.DirectShow;
using System;
using System.IO.Ports;

namespace BarcodeScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            var barcodeConfig = new BarcodeSettings()
            {
                ComPort = "com1",
                BaudRate = 9600,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One,
                StartDelimiter = "",
                EndDelimiter = ""
            };

            var scanner = new BarcodeScanner();
            scanner.Enable(barcodeConfig);

            //cy.get('body').type("MY BARCODE").trigger('keydown', { keyCode: 13, which: 13 })
        }
    }
}
