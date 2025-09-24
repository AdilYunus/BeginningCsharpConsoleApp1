using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class RelatieBase12 : IRelatie
    {
        public RelatieBase12(
            int burgerservicenummer, 
            DateTime geboortedatum,
            GeslachtType geslacht, 
            string voornaam,
            string geslachtsnaam,
            int nummer = 0,
            int uzovicode = 0)
        {
            Burgerservicenummer = burgerservicenummer;
            Geboortedatum = geboortedatum;
            Geslacht = geslacht;
            Voornaam = voornaam;
            Geslachtsnaam = geslachtsnaam;
            Nummer = nummer;
            Uzovicode = uzovicode;
        }
        public int Nummer { get; set; }
        public int Uzovicode { get; set; }
        [IsRequired(true)]
        public string Voornaam { get; set; }
       
        public int Burgerservicenummer { get; set; }
        public DateTime Geboortedatum { get; set; }
        public GeslachtType Geslacht { get; set; }

        //[IsRequired(true)]
        [MyStringLengthAttribute(2,15)]
        public string Geslachtsnaam { get; set; }
        public override string ToString()
        {
            return string.Format($"{Burgerservicenummer} {Geboortedatum:ddMMyyyy}");
        }
        public virtual int GeefLeeftijd()
        {
            return 30;
        }
    }
}
