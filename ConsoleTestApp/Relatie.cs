using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class Relatie : RelatieBase
    {
        public string VolledigeNaam => $"{Voornaam} {Geslachtsnaam}";

        public Relatie(int burgerservicenummer, DateTime geboortedatum, GeslachtType geslacht, string voornaam, string geslachtsnaam)
            : base(burgerservicenummer, geboortedatum, geslacht, voornaam, geslachtsnaam)
        {
        }

        public Relatie(int burgerservicenummer, DateTime geboortedatum, GeslachtType geslacht, string voornaam, string geslachtsnaam, int nummer, int uzovicode)
            : base(burgerservicenummer, geboortedatum, geslacht, voornaam, geslachtsnaam, nummer, uzovicode)
        {
        }
        public override string ToString()
        {
            return string.Format("{0} {1:ddMMyyyy} {2}-{3}",
                Burgerservicenummer, Geboortedatum, Nummer, Uzovicode);
        }
    }
}
