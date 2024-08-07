using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWeekClosing
{
    public class Phone : BaseClass
    {
        public bool TrLicense { get; set; }
        
        public override void WriteInfo()
        {
            base.WriteInfo();
            Console.WriteLine($"Lisan Durumu : {TrLicense}");
        }
        public override void GetName()
        {
            Console.WriteLine($"Telefonunuzun Adı : => {Name}");
        }
    }
}
