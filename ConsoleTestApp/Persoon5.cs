using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class Persoon5
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime Geboortedatum { get; set; }

        public override string ToString()
        {
            return $"naam: {Voornaam} {Achternaam},\ngeboortedatum: {Geboortedatum.ToShortDateString()}";
        }
    }

    public class Werknemer
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public DateTime DatumInDienst { get; set; }

        public override string ToString()
        {
            return $"naam :{Voornaam} {Achternaam},\nGeboortedatum: {Geboortedatum.ToShortDateString()},\ndatum in dienst: {DatumInDienst.ToShortDateString()}";
        }
    }
    public class Testing

    {

        private string _waarde;


        public string Waarde
        {
            get => _waarde;
            set => _waarde = value;
        }
    }
}
