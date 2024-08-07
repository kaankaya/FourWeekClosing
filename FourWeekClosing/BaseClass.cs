using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWeekClosing
{
    //Ana Base Classımız
    //Tüm ortak özelliklerimiz bu class dan türüyor
    public abstract class BaseClass
    {
        //Ortak Property Tanımnları
        public DateTime ProductionDate { get; private set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }
        //Nesne oluştugunda otomatik tarih için
        public BaseClass() 
        {
            ProductionDate = DateTime.Now;
        }
        //Ortak özelliklerin ekrana yazdırımı
        public virtual void WriteInfo()
        {
            
            Console.WriteLine($"Ürün Tarihi : {ProductionDate}\nSeri Numarası : {SerialNumber}\nÜrün Adı:{Name}\nÜrün Açıklaması : {Description}\nİşletim Sistemi : {OperatingSystem}");
        }
        //Ürün adı getirmesi için abstract bir method
        public abstract void GetName();

    }
}
