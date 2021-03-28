using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KeysightScanner.Services.QRScanner
{
    public interface IQRScannerService
    {
        Task<string> LaunchCameraScanner();
        Task<string> LaunchFileScanner();
    }
}
