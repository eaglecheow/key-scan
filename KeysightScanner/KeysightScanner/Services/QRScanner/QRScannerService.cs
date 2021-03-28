using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KeysightScanner.Services.QRScanner
{
    class QRScannerService: IQRScannerService
    {
        public async Task<string> LaunchCameraScanner()
        {
            var scanner = new ZXing.Mobile.MobileBarcodeScanner();
            var result = await scanner.Scan();

            return result.Text;
        }

        public async Task<string> LaunchFileScanner()
        {
            throw new NotImplementedException();
        }
    }
}
