using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public enum GeslachtType1 { Man, Vrouw }

    public class Rekening
    {
        public int Id { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }
        public string Tenaamstelling { get; set; }
        public string Woonplaats { get; set; }
    }

    public class Relatie14
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Geslachtsnaam { get; set; }
        public int Burgerservicenummer { get; set; }
        public DateTime Geboortedatum { get; set; }
        public GeslachtType1 Geslachtsaanduiding { get; set; }
        public List<Rekening> Rekeningen { get; set; }
        public int Leeftijd
        {
            get
            {
                var vandaag = DateTime.Today;
                var leeftijd = vandaag.Year - Geboortedatum.Year;
                if (Geboortedatum.Date > vandaag.AddYears(-leeftijd)) leeftijd--;
                return leeftijd;
            }
        }
    }

}