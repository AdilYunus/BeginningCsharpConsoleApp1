using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    internal class Persoon9
    {
        public int Burgerservicenummer { get; set; }
        public DateTime Geboortedatum { get; set; }

        // 
        public Persoon9(int burgerservicenummer, DateTime geboortedatum)
        {
            this.Burgerservicenummer = burgerservicenummer; // 
        }

        public override string ToString()
        {
            // 
            return string.Format("{0} {1:ddMMyyyy}", this.Burgerservicenummer, this.Geboortedatum);
        }
    }
}
