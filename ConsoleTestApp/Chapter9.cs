using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class Chapter9
    {
        public static void Test()
        {
            // 1. Demonstratie van methodeverbergen (met 'new')
            //Console.WriteLine("--- Demonstratie van methodeverbergen ---");
            //RelatieBase relatieBase = new RelatieBase(194602874, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Bakker", 1234, 7029);
            //Relatie relatie = new Relatie(194602874, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Bakker", 1234, 7029);
            //RelatieBase relatie2 = relatie; // Wijst het exemplaar van de afgeleide klasse toe aan een variabele van de basisklasse

            //Console.WriteLine("Leeftijd relatie (basisklasse) {0}", relatieBase.GeefLeeftijd());
            //Console.WriteLine("Leeftijd relatie (afgeleide klasse) {0}", relatie.GeefLeeftijd());
            //Console.WriteLine("Leeftijd relatie2 {0}", relatie2.GeefLeeftijd());

            //// Verwachte uitvoer: 30, 40, 30
            //Console.WriteLine("\nDit demonstreert het gedrag van methodeverbergen:");
            //Console.WriteLine("- Het type van de variabele 'relatie2' is 'RelatieBase', dus roept deze de methode van de basisklasse aan en retourneert 30.");
            //Console.WriteLine("- Dit is meestal niet het verwachte gedrag, en daarom geeft de compiler een waarschuwing.");

            //Console.WriteLine("\n------------------------\n");

            // 2. Demonstratie van methode-overschrijven (met 'virtual' en 'override')
            //Console.WriteLine("--- Demonstratie van methode-overschrijven (de juiste manier) ---");

            //Op dit punt moet de commentaar van GeefLeeftijd() hierboven worden verwijderd en de 'new' - versie worden uit-gecommentarieerd
             //Voer het programma opnieuw uit om de volgende resultaten te krijgen:

            //RelatieBase relatieBase = new RelatieBase(194602874, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Bakker", 1234, 7029);
            //Relatie relatie = new Relatie(194602874, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Bakker", 1234, 7029);
            //RelatieBase relatie2 = relatie;

            //Console.WriteLine("Leeftijd relatie (base class) {0}", relatieBase.GeefLeeftijd());
            //Console.WriteLine("Leeftijd relatie (derived class) {0}", relatie.GeefLeeftijd());
            //Console.WriteLine("Leeftijd relatie2 {0}", relatie2.GeefLeeftijd());

            //Verwachte uitvoer: 30, 40, 40
            //Console.WriteLine("Leeftijd relatie (basisklasse) 30");
            //Console.WriteLine("Leeftijd relatie (afgeleide klasse) 40");
            //Console.WriteLine("Leeftijd relatie2 40");

            //Console.WriteLine("\nDit demonstreert het gedrag van methode-overschrijven:");
            //Console.WriteLine("- Hoewel het type van 'relatie2' 'RelatieBase' is, verwijst het feitelijke object naar een 'Relatie'-type.");
            //Console.WriteLine("- De runtime roept de daadwerkelijke methode van het object aan en retourneert daarom 40.");
            //Console.WriteLine("- Dit is de kracht van polymorfisme; het maakt code flexibeler en voorspelbaarder.");

            //Console.ReadKey();
        }

        public static void Exercise1()
        {
            Relatie relatie = new Relatie(194602874, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Bakker", 1234, 7029);

            // Exercise 1
            Console.WriteLine("Naam van de relatie: {0}", relatie.VolledigeNaam);
            //Exercise 4
            Console.WriteLine("Naam van de relatie {0}, {1}", relatie.VolledigeNaam, relatie.ToString());

            Console.ReadKey();

        }

        public static void Exercise4()
        {
            Relatie relatie = new Relatie(194602874, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Bakker", 1234, 7029);

           
            //Exercise 4
            Console.WriteLine("Naam van de relatie {0}, {1}", relatie.VolledigeNaam, relatie.ToString());

            Console.ReadKey();

        }

        public static void Exercise5()
        {
            Relatie relatie = new Relatie(194602874, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Bakker", 1234, 7029);
            //Exercise 5
            Console.WriteLine(relatie.ToString());

            Console.ReadKey();

        }


    }
}
