using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class Relatie12 : RelatieBase12, IComparable<Relatie12>
    {
        public Relatie12(int burgerservicenummer,
            DateTime geboortedatum, 
            GeslachtType geslacht, 
            string voornaam,
            string geslachtsnaam,
            int nummer = 0,
            int uzovicode = 0)
            : base(burgerservicenummer, geboortedatum, geslacht, voornaam, geslachtsnaam,nummer,uzovicode)
        {
        }
        
        public override string ToString()
        {
            return string.Format($"{Burgerservicenummer} {Geboortedatum:ddMMyyyy} {Nummer}-{Uzovicode}");
        }
        public override int GeefLeeftijd()
        {
            return base.GeefLeeftijd() + 5;
        }
        public int CompareTo(Relatie12 other)
        {
            if (other == null)
            {
                return -1;
            }
            return Geboortedatum.CompareTo(other.Geboortedatum);
        }
    }
}
