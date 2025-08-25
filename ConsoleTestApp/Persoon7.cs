using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public interface IPersoon7
    {
        string Voornaam { get; set; }
        string Achternaam { get; set; }
        DateTime Geboortedatum { get; set; }
    }

    public class Persoon7 : IPersoon7
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime Geboortedatum { get; set; }

        public override string ToString()
        {
            return $"naam: {Voornaam} {Achternaam}, \ngeboortedatum: {Geboortedatum.ToShortDateString()}";
        }
    }

}
