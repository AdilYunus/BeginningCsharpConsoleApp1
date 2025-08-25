using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class Persoon6
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime Geboortedatum { get; set; }

        public override string ToString()
        {
            return $"naam: {Voornaam} {Achternaam}, \ngeboortedatum: {Geboortedatum.ToShortDateString()}";
        }
    }

    public class Werknemer6 : Persoon6
    {
        public DateTime DatumInDienst { get; set; }

        public override string ToString()
        {
            return $"persoon info :\n{base.ToString()},\ndatum in dienst: {DatumInDienst.ToShortDateString()}";
        }
    }
}

