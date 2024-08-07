using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FourWeekClosing
{
    public class Computer : BaseClass
    {
        //usb port için kontrol
        public int usbPorts;
        public int UsbPorts
        {
            get
            {
                return usbPorts;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    usbPorts = value;
                }
                else
                {
                    Console.WriteLine("!!!HATA!! Usb Giriş Sayısı 2 veya 4 olabilir !!!");
                    usbPorts = -1;
                }
            }
        }
        public bool Bluetooth { get; set; }
        //Bilgisayara ait olan ek özelliklerin de yazdırma methoduna eklenmesi
        public override void WriteInfo()
        {
            base.WriteInfo();
            Console.WriteLine($"Usb PortSayısı: {UsbPorts}\nBluetooth : {Bluetooth}");
        }
        public override void GetName()
        {
            Console.WriteLine($"Bilgisayarınızın Adı : => {Name}");
        }
    }
}
