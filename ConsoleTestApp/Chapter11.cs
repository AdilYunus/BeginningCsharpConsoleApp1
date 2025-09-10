using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class Chapter11
    {
        public static void Exercise1()
        {
            int? x = null;
            int y = x ?? 0;
            Console.WriteLine(y);
        }

        public static void Exercise2()
        {
            string s = null;
            string w;
            string z;
            if (s != null)
            {
                w = s;
            }
            else
            {
                w = "default";
            }

            Console.WriteLine($"w = {w}");

            z = s ?? "default";
            Console.WriteLine(z);
        }

        public static void Exercise3()
        {
            Relatie relatie1 = new Relatie(194602874, new DateTime(1975, 9, 3), GeslachtType.Man, "John", "Bakker", 123, 7029);
            Relatie relatie2 = new Relatie(420645858, new DateTime(1991, 2, 27), GeslachtType.Vrouw, "Chantal", "Mijndertsma", 789, 7029);
            Relatie relatie3 = new Relatie(476970854, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Boomsma", 456, 7037);

            //Ik wil de relatiecollection niet overschrijven, daarom heb ik RelatieCollection1 gemaakt
            RelatieCollection1 relaties = new RelatieCollection1();
            relaties.Add(relatie1);
            relaties.Add(relatie2);
            relaties.Add(relatie3);
            Console.WriteLine("\nforeach :");
            foreach (Relatie relatie in relaties)
            {
                Console.WriteLine($"relatie's info: {relatie}");
            }

            Console.WriteLine("\nfor :");
            for (int i = 0; i < relaties.Count; i++)
            {
                Console.WriteLine($"relatie's info: {relaties[i]}" );
            }

            Console.ReadKey();
        }

        public static void Exercise5()
        {
            Relatie relatie1 = new Relatie(194602874, new DateTime(1975, 9, 3), GeslachtType.Man, "John", "Bakker", 123, 7029);
            Relatie relatie2 = new Relatie(420645858, new DateTime(1991, 2, 27), GeslachtType.Vrouw, "Chantal", "Mijndertsma", 789, 7029);
            Relatie relatie3 = new Relatie(476970854, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Boomsma", 456, 7037);

            RelatieCollection1 relaties = new RelatieCollection1 { relatie1, relatie2, relatie3 };

            relaties.Sort();

            foreach (var relatie in relaties)
            {
                Console.WriteLine($"Naam van de relatie is {relatie.VolledigeNaam}, geboortedatum {relatie.Geboortedatum:dd-MM-yyyy}");
            }

            Console.ReadKey();
        }

        public static void Exercise6()
        {

            Relatie relatie1 = new Relatie(194602874, new DateTime(1975, 9, 3),
                GeslachtType.Man, "John", "Bakker", 123, 7029);
            Relatie relatie2 = new Relatie(420645858, new DateTime(1991, 2, 27),
                GeslachtType.Vrouw, "Chantal", "Mijndertsma", 789, 7029);
            Relatie relatie3 = new Relatie(476970854, new DateTime(1985, 8, 11),
                GeslachtType.Vrouw, "Monique", "Boomsma", 456, 7037);

            RelatiesDict1 relatiesDict = new RelatiesDict1();
            relatiesDict.Add(relatie1.Nummer, relatie1);
            relatiesDict.Add(relatie2.Nummer, relatie2);
            relatiesDict.Add(relatie3.Nummer, relatie3);

            foreach (Relatie relatie in relatiesDict.Values)
            {
                Console.WriteLine($"Naam van de relatie is {relatie.VolledigeNaam}");
            }

            relatiesDict.Remove(relatie2.Nummer);
            Console.WriteLine("na verwijderen");

            foreach (Relatie relatie in relatiesDict.Values)
            {
                Console.WriteLine($"Naam van de relatie is {relatie.VolledigeNaam}");
            }
            Console.ReadKey();
        }

        public static void Exercise7()
        {
            Relatie relatie1 = new Relatie(194602874, new DateTime(1975, 9, 3), GeslachtType.Man, "John", "Bakker", 123, 7029);
            Relatie relatie2 = new Relatie(420645858, new DateTime(1991, 2, 27), GeslachtType.Vrouw, "Chantal", "Mijndertsma", 789, 7029);
            Relatie relatie3 = new Relatie(476970854, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Boomsma", 456, 7037);

            RelatieCollection2<Relatie> relaties = new RelatieCollection2<Relatie>();
            relaties.Add(relatie1);
            relaties.Add(relatie2);
            relaties.Add(relatie3);

            foreach (Relatie relatie in relaties)
            {
                Console.WriteLine("Relatie {0}", relatie.VolledigeNaam);
            }
            Console.ReadKey();
        }
    }
}


