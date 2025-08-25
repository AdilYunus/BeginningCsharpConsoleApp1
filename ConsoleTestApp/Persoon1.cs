using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    internal class Persoon1()
    {
        public string Geslachtsnaam;
        public int Burgerservicenummer;
        public string GeefDetails()
        {
            return $"Geslachtsnaam: {Geslachtsnaam}, BSN: {Burgerservicenummer}";
        }
    }
}


