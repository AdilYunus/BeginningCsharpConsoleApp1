using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class Relatie : RelatieBase, IComparable, IComparable<Relatie>
    {
        public string VolledigeNaam => $"{Voornaam} {Geslachtsnaam}";

        public Relatie(int burgerservicenummer, DateTime geboortedatum, GeslachtType geslacht, string voornaam,
            string geslachtsnaam)
            : base(burgerservicenummer, geboortedatum, geslacht, voornaam, geslachtsnaam)
        {
        }

        public Relatie(int burgerservicenummer, DateTime geboortedatum, GeslachtType geslacht, string voornaam,
            string geslachtsnaam, int nummer, int uzovicode)
            : base(burgerservicenummer, geboortedatum, geslacht, voornaam, geslachtsnaam, nummer, uzovicode)
        {
        }

        public override string ToString()
        {
            return string.Format("{0} {1:ddMMyyyy} {2}-{3}",
                Burgerservicenummer, Geboortedatum, Nummer, Uzovicode);
        }

        public int CompareTo(object other)
        {
            Relatie r = other as Relatie;
            if (other == null || r == null)
            {
                return -1;
            }
            //asc voor exercise 10-5
            //return Geboortedatum.CompareTo(r.Geboortedatum);

            //desc voor erercise 10-6
            return -Geboortedatum.CompareTo(r.Geboortedatum);
        }

        //exercise 11-5
        public int CompareTo(Relatie other)
        {
            if (other == null) return 1;
            return this.Geboortedatum.CompareTo(other.Geboortedatum);

        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Relatie other = obj as Relatie;
            if (other == null)
            {
                return false;
            }
            //return this.Burgerservicenummer.Equals(other.Burgerservicenummer);
            return Equals(other);
            //return false;

        }
        public bool Equals(Relatie other)
        {
            if (other == null)
            {
                return false;
            }
            return this.Burgerservicenummer.Equals(other.Burgerservicenummer);

        }

    }
}
