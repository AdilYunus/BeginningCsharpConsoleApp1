using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    internal class Persoon2
    {
        public string Geslachtsnaam;
        public int Burgerservicenummer;

        public Persoon2(String geslachtsnaam, int burgerservicenummer)
        {
           Geslachtsnaam = geslachtsnaam;
           Burgerservicenummer = burgerservicenummer;
        }

        public string GeefDetails()
        {
            return $"Geslachtsnaam: {Geslachtsnaam}, BSN: {Burgerservicenummer}";
        }

    }
}
