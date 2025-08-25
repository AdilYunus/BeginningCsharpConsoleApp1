using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    internal class Persoon3: PersoonBase
    {
        public string Geslachtsnaam;
        public int Burgerservicenummer;

        public Persoon3(String geslachtsnaam, int burgerservicenummer, DateTime geboortedatum)
        {
            Geslachtsnaam = geslachtsnaam;
            Burgerservicenummer = burgerservicenummer;
            Geboortedatum = geboortedatum;
        }

        public string GeefDetails()
        {
            return $"Geslachtsnaam: {Geslachtsnaam}, BSN: {Burgerservicenummer}," +
                   $"DOB: {Geboortedatum.ToShortDateString()}" ;
        }

    }
}
