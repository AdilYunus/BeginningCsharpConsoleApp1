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
        private int _burgerservicenummer;
        private DateTime _geboortedatum;
        private GeslachtType _geslacht;
        private string _voornaam = string.Empty;
        private string _geslachtsnaam = string.Empty;
        private int _nummer;
        private int _uzovicode;

        public int Burgerservicenummer
        {
            get { return _burgerservicenummer; }
            set { _burgerservicenummer = value; }
        }

        public DateTime Geboortedatum
        {
            get { return _geboortedatum; }
            set { _geboortedatum = value; }
        }

        public GeslachtType Geslacht
        {
            get { return _geslacht; }
            set { _geslacht = value; }
        }

        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public string Geslachtsnaam
        {
            get { return _geslachtsnaam; }
            set { _geslachtsnaam = value; }
        }

        public int Nummer
        {
            get { return _nummer; }
            set { _nummer = value; }
        }

        public int Uzovicode
        {
            get { return _uzovicode; }
            set { _uzovicode = value; }
        }

        public string VolledigeNaam
        {
            get { return Voornaam + " " + Geslachtsnaam; }
        }

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
    }

}

