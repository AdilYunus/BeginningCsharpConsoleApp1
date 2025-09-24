using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    internal class Chapter12
    {
        public static void Exercise2()
        {
            Relatie12 r1 = new Relatie12(194602874, new DateTime(1975, 9, 3), GeslachtType.Man, "John", "Bakker");
            Console.WriteLine($"{r1.Voornaam} {r1.Geslachtsnaam}, Nummer={r1.Nummer}, Uzovicode={r1.Uzovicode}");

            Relatie12 r2 = new Relatie12(420645858, new DateTime(1991, 2, 27), GeslachtType.Vrouw, "Chantal", "Mijndertsma", 123, 7029);
            Console.WriteLine($"{r2.Voornaam} {r2.Geslachtsnaam}, Nummer={r2.Nummer}, Uzovicode={r2.Uzovicode}");

            Relatie12 relatie3 = new Relatie12(476970854, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Boomsma");
            Console.WriteLine($"{relatie3.Voornaam} {relatie3.Geslachtsnaam}, Nummer={relatie3.Nummer}, Uzovicode={relatie3.Uzovicode}");

        }

        public static void Exercise3()
        {
            Relatie12 relatie = new Relatie12(476970854, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Boomsma");
            //Console.WriteLine($"{relatie3.Voornaam} {relatie3.Geboortedatum}, Nummer={relatie3.Nummer}, Uzovicode={relatie3.Uzovicode}");

            Console.WriteLine($"Geboortedatum: {relatie.GeboortedatumFormat()}");
            Console.WriteLine($"Geboortedatum (yyyy/MM/dd): {relatie.GeboortedatumFormat("yyyy/MM/dd")}");
        }

        delegate void SchrijfSamen(string a, string b);

        public static void Exercise4()
        {
            string eerste = "Dit is het eerste deel";
            string tweede = "en dit is het vervolg!";

            SchrijfSamen schrijfSamenA = (a, b) => Console.WriteLine($"{a} {b}");

            schrijfSamenA(eerste, tweede);

            Console.ReadKey();

        }
        delegate string VoegSamen(string a, string b);

        public static void Exercise5()
        {
            string eerste = "Dit is het eerste deel";
            string tweede = "en dit is het vervolg!";

            VoegSamen voegSamen = (a, b) => $"{a}{b}";
            string samen = voegSamen(eerste, tweede);
            Console.WriteLine(samen);
            Console.ReadKey();
        }

        public static void Exercise6()
        {
            Relatie relatie1 = new Relatie(194602874, new DateTime(1975, 9, 3), GeslachtType.Man, "John", "Bakker");
            Relatie relatie2 = new Relatie(420645858, new DateTime(1991, 2, 27), GeslachtType.Vrouw, "Chantal", "Mijndertsma");
            Relatie relatie3 = new Relatie(476970854, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Boomsma");

            var relaties = new List<Relatie> { relatie1, relatie2, relatie3 };

            //Predicate<Relatie> relatiesVrouw = (Relatie relatie) => { return relatie.Geslacht == GeslachtType.Vrouw; };
            //Predicate<Relatie> relatiesMetNaam = (Relatie relatie) => { return relatie.Geslachtsnaam == "Boomsma"; };

            Predicate<Relatie> relatiesVrouw = relatie => relatie.Geslacht == GeslachtType.Vrouw;
            Predicate<Relatie> relatiesMetNaam = relatie => relatie.Geslachtsnaam == "Boomsma";

            var resultaat = relaties.Find(relatiesVrouw);
            Console.WriteLine(resultaat.VolledigeNaam);

            resultaat = relaties.Find(relatiesMetNaam);
            Console.WriteLine(resultaat.VolledigeNaam);

            Console.ReadKey();
        }

        public static void Exercise7()
        {
            Action<string> writeLine = s => Console.WriteLine(s);
            Func<DateTime, string> formatDate = d => string.Format($"{d:dd-MM-yyyy}");
            writeLine("Using the delegate with an anonymous method");
            writeLine("The current date is " + formatDate(DateTime.Today));

            Console.ReadKey();
        }
        public static void Exercise8_9()
        {
            Relatie12 relatie1 = new Relatie12(194602874, new DateTime(1975, 9, 3), GeslachtType.Man, "", "B");
            Relatie12 relatie2 = new Relatie12(420645858, new DateTime(1991, 2, 27), GeslachtType.Vrouw, "Chantal", "Mijndertsma");
            Relatie12 relatie3 = new Relatie12(476970854, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Boomsma");

            var validator = new Validator(relatie1);
            if (!validator.Validate())
            {
                Console.WriteLine($"Relatie is niet valide: {validator.BrokenRules}");
            }
            else
            {
                Console.WriteLine("Relatie is valide");
            }
            Console.ReadKey();
        }

    }
}
