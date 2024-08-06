using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Device
    {
        public int DeviceID { get; set; }
        public string Name { get; set; }
        public DeviceType DeviceType { get; set; }
    }

    public enum DeviceType
    {
        BarcodeScanner,
        Printer,
        Camera,
        SocketTray
    }
}
