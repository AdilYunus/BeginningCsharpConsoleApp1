using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleTestApp.Chapter9;

namespace ConsoleTestApp
{
    
    public class RelatieBase : IRelatie
        {
        /* exercise 9-3*/
        public int Burgerservicenummer { get; set; }
        public DateTime Geboortedatum { get; set; }
        public GeslachtType Geslacht { get; set; }
        public string Voornaam { get; set; } = string.Empty;
        public string Geslachtsnaam { get; set; } = string.Empty;
        public int Nummer { get; set; }
        public int Uzovicode { get; set; }

        //----------------

        /*hier onder voor Exercise 9-1*/

        //private int _burgerservicenummer;
        //private DateTime _geboortedatum;
        //private GeslachtType _geslacht;
        //private string _voornaam = string.Empty;
        //private string _geslachtsnaam = string.Empty;
        //private int _nummer;
        //private int _uzovicode;

        //public int Burgerservicenummer
        //{
        //    get { return _burgerservicenummer; }
        //    set { _burgerservicenummer = value; }
        //}

        //public DateTime Geboortedatum
        //{
        //    get { return _geboortedatum; }
        //    set { _geboortedatum = value; }
        //}

        //public GeslachtType Geslacht
        //{
        //    get { return _geslacht; }
        //    set { _geslacht = value; }
        //}

        //public string Voornaam
        //{
        //    get { return _voornaam; }
        //    set { _voornaam = value; }
        //}

        //public string Geslachtsnaam
        //{
        //    get { return _geslachtsnaam; }
        //    set { _geslachtsnaam = value; }
        //}

        //public int Nummer
        //{
        //    get { return _nummer; }
        //    set { _nummer = value; }
        //}

        //public int Uzovicode
        //{
        //    get { return _uzovicode; }
        //    set { _uzovicode = value; }
        //}

        //public string VolledigeNaam
        //{
        //    get { return Voornaam + " " + Geslachtsnaam; }
        //}
        //--------------------------------------------------------

        public RelatieBase(int burgerservicenummer, DateTime geboortedatum, GeslachtType geslacht, string voornaam, string geslachtsnaam)
            : this(burgerservicenummer, geboortedatum, geslacht, voornaam, geslachtsnaam, 0, 0)
        {
        }

        public RelatieBase(int burgerservicenummer, DateTime geboortedatum, GeslachtType geslacht,
                           string voornaam, string geslachtsnaam, int nummer, int uzovicode)
        {
            Burgerservicenummer = burgerservicenummer;
            Geboortedatum = geboortedatum;
            Geslacht = geslacht;
            Voornaam = voornaam;
            Geslachtsnaam = geslachtsnaam;
            Nummer = nummer;
            Uzovicode = uzovicode;
        }

        // Exercise 4

        public override string ToString()
        {
            return string.Format("{0} {1:dd-MM-yyyy}", Burgerservicenummer, Geboortedatum);
        }
    }

}

