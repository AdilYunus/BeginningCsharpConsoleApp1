using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public enum GeslachtType
    {
        Man,
        Vrouw,
        Onbekend
    }
    public interface IRelatie
    {
        int Burgerservicenummer { get; }
        DateTime Geboortedatum { get; }
        GeslachtType Geslacht { get; }
        string Voornaam { get; }
        string Geslachtsnaam { get; }
        int Nummer { get; }
        int Uzovicode { get; }
        string VolledigeNaam { get; }
    }
}
