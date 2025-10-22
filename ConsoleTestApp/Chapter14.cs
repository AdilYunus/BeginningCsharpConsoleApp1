using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleTestApp
{
    public class Chapter14
    {
        public static void Exercise1()
        {
            var namen = new string[] { "Jan", "Klaas", "Bart", "Gerard", "Herman", "Jaqueline" };

            //var namenSelectie = from naam in namen
            //    where naam.StartsWith("Ja") || naam.Length < 5
            //    select naam;

            var namenSelectie = namen
                .Where(naam => naam.StartsWith("Ja") || naam.Length < 5)
                .Select(naam => naam);
            Console.WriteLine("namenSelectie:");
            foreach (var naam in namenSelectie)
                Console.WriteLine(naam);

            //var namenSort = from naam in namen
            //    orderby naam
            //    select naam;

            var namenSort = namen
                .OrderBy(naam => naam)
                .Select(naam => naam);

            Console.WriteLine("\nnamenSort:");
            foreach (var naam in namenSort)
                Console.WriteLine(naam);



            //var vrouwen = from relatie in relaties
            //    where relatie.Geslachtsaanduiding == GeslachtType.Vrouw
            //    select relatie.Geslachtsnaam;

            var relaties = new List<Relatie14>
            {
                new Relatie14
                {
                    Id = 1,
                    Voornaam = "Japie",
                    Geslachtsnaam = "Krekel",
                    Geslachtsaanduiding = GeslachtType1.Man,
                    Rekeningen = new List<Rekening>
                    {
                        new Rekening
                        {
                            Id = 1,
                            Iban = "NL20INGB3909255345",
                            Bic = "INGBNL2A",
                            Tenaamstelling = "Japie Krekel",
                            Woonplaats = "Rotterdam"
                        }
                    }
                },
                new Relatie14
                {
                    Id = 2,
                    Voornaam = "Chantal",
                    Geslachtsnaam = "Mijndertsma",
                    Geslachtsaanduiding = GeslachtType1.Vrouw
                },
                new Relatie14
                {
                    Id = 3,
                    Voornaam = "Monique",
                    Geslachtsnaam = "Boomsma",
                    Geslachtsaanduiding = GeslachtType1.Vrouw
                }
            };
            
            var vrouwen = relaties
                .Where(r => r.Geslachtsaanduiding == GeslachtType1.Vrouw)
                .Select(r => r.Geslachtsnaam);

            Console.WriteLine("\nVrouwen:");
            foreach (var naam in vrouwen)
                Console.WriteLine(naam);

            Console.ReadKey();
        }

        public static void Exercise2()
        {
            var namen = new string[] { "Jan", "Klaas", "Bart", "Gerard", "Herman", "Jaqueline" };

        
            List<Relatie14> relaties = new List<Relatie14>
        {
        new Relatie14
        {
            Id = 1,
            Voornaam = "Japie",
            Geslachtsnaam = "Krekel",
            Geslachtsaanduiding = GeslachtType1.Man,
            Geboortedatum = new DateTime(2005, 3, 10),
            Rekeningen = new List<Rekening> 
            {
                new Rekening
                {
                    Id = 1,
                    Iban = "NL20INGB3909255345",
                    Bic = "INGBNL2A",
                    Tenaamstelling = "Japie Krekel",
                    Woonplaats = "Rotterdam",

                },
                new Rekening
                {
                    Id = 2,
                    Iban = "NL20INGB3909255345",
                    Bic = "INGBNL2A",
                    Tenaamstelling = "Japie Krekel",
                    Woonplaats = "Rotterdam"
                }
            }
        },
        new Relatie14
        {
            Id = 2,
            Voornaam = "Chantal",
            Geslachtsnaam = "Mijndertsma",
            Geslachtsaanduiding = GeslachtType1.Vrouw,
            Geboortedatum = new DateTime(2001, 3, 10),
            Rekeningen = new List<Rekening>()
            {
                new Rekening
                {
                    Id = 1,
                    Iban = "NL20INGB3909255345",
                    Bic = "INGBNL2A",
                    Tenaamstelling = "Japie Krekel",
                    Woonplaats = "Rotterdam"
                }
            }
        },
        new Relatie14
        {
            Id = 3,
            Voornaam = "Monique",
            Geslachtsnaam = "Boomsma",
            Geslachtsaanduiding = GeslachtType1.Vrouw,
            Geboortedatum = new DateTime(2019, 3, 10),
            Rekeningen = new List<Rekening>() 
        }
        };

            // 1
            var relatiesMetRekeningQuerry = from relatie in relaties
                                            where relatie.Rekeningen.Any() 
                                            select relatie;

            var relatiesMetRekeningMethodes = relaties
                .Where(relatie => relatie.Rekeningen.Any());

            Console.WriteLine("\nRelatie met minstens één rekening (Method Syntax):");

           
            foreach (var relatie in relatiesMetRekeningMethodes)
            {
                Console.WriteLine($"ID: {relatie.Id}, Naam: {relatie.Voornaam} {relatie.Geslachtsnaam}");
                Console.WriteLine($"\tAantal rekeningen: {relatie.Rekeningen.Count}");
            }

            // 2
            var jongeMannenQ = from relatie in relaties
                where relatie.Leeftijd < 25 && relatie.Geslachtsaanduiding == GeslachtType1.Man
                orderby relatie.Geslachtsnaam descending
                select relatie.Geslachtsnaam;

            // Method syntax
            var jongeMannenM = relaties
                .Where(relatie => relatie.Leeftijd < 25 && relatie.Geslachtsaanduiding == GeslachtType1.Man)
                .OrderByDescending(relatie => relatie.Geslachtsnaam)
                .Select(relatie => relatie.Geslachtsnaam);


            foreach (var naam in jongeMannenM)
                Console.WriteLine("naam van jonge man: {0}\n",naam);
            Console.WriteLine();

            //3
            var jongsteVrouwQ = (from relatie in relaties
                where relatie.Geslachtsaanduiding == GeslachtType1.Vrouw
                select relatie.Geboortedatum).Min();
            // Method syntax
            var jongsteVrouwM = relaties
                .Where(relatie => relatie.Geslachtsaanduiding == GeslachtType1.Vrouw)
                .Min(relatie => relatie.Geboortedatum);
          
            Console.WriteLine($"Gebortedatum van jonge vrouw: {jongsteVrouwM:dd-MM-yyyy}");
            Console.WriteLine();

            //4

            var manCountQ = (from relatie in relaties
                where relatie.Geslachtsaanduiding == GeslachtType1.Man
                select relatie).Count();
            // Method syntax
            var manCountM = relaties.Count(relatie => relatie.Geslachtsaanduiding == GeslachtType1.Man);
            Console.WriteLine($"mannen: {manCountM}");
            Console.WriteLine();

            //5

            var avgLeeftijdQ = (from relatie in relaties select relatie.Leeftijd).Average();

            // Method syntax
            var avgLeeftijdM = relaties.Average(relatie => relatie.Leeftijd);
            Console.WriteLine($"{avgLeeftijdM:F1} jaar gemiddeld.");

            Console.ReadKey();

        }

    }
}
