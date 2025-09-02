using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class Chapter10
    {
        public static void Test()
        {

            {

                Relatie relatie1 = new Relatie(194602874, new DateTime(1975, 9, 3), GeslachtType.Man, "John", "Bakker",
                    123, 7029);

                Relatie relatie2 = new Relatie(476970854, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique",
                    "Boomsma", 456, 7037);

                Relatie relatie3 = new Relatie(420645858, new DateTime(1991, 2, 27), GeslachtType.Vrouw, "Chantal",
                    "Mijndertsma", 789, 7029);



                Console.WriteLine("Gebruik in de array");



                // array datatype

                Relatie[] relatiesArray = new Relatie[] { relatie1, relatie2, relatie3 };

                foreach (Relatie relatieInArray in relatiesArray)

                {

                    Console.WriteLine("Naam van de relatie is {0}", relatieInArray.VolledigeNaam);

                }



                Console.WriteLine("Gebruik in de ArrayList");

                // Arraylist (list of objects!)

                ArrayList relatieList = new ArrayList();

                relatieList.Add(relatie1); // instantie van Relatie

                relatieList.Add(relatie2);

                relatieList.Add(relatie3);

                relatieList.Add(17); // integer

                relatieList.Add("relatie"); // string



                // We kunnen ook de lijst in één keer vullen:

                // ArrayList relatieList = new ArrayList { relatie1, relatie2, relatie3 };

                // Of initialiseren met een array:

                // ArrayList relatieList = new ArrayList(relatiesArray);



                foreach (object relatieInArrayList in relatieList)

                {

                    Console.WriteLine("Item op index {0}:", relatieList.IndexOf(relatieInArrayList));

                    if (relatieInArrayList.GetType() == typeof(Relatie))

                    {

                        Console.WriteLine("Naam van de relatie is {0}", ((Relatie)relatieInArrayList).VolledigeNaam);

                    }

                    else

                    {

                        Console.WriteLine("Waarde van dit item is {0}", relatieInArrayList.ToString());

                    }

                }

                Console.WriteLine("Using RelatieCollection with a for loop and indexer");



                // de arraylist kan gemanipuleerd worden

                Console.WriteLine("Aantal elementen in de ArrayList = {0}", relatieList.Count);

                relatieList.RemoveAt(4);

                Console.WriteLine("Aantal elementen in de ArrayList = {0}", relatieList.Count);

                relatieList.Remove(relatie2);

                Console.WriteLine("Aantal elementen in de ArrayList = {0}", relatieList.Count);



                Console.ReadKey();

            }



        }

        public static void Exercise1()
        {
            Relatie relatie1 = new Relatie(194602874, new DateTime(1975, 9, 3), GeslachtType.Man, "John", "Bakker", 123,
                7029);
            Relatie relatie2 = new Relatie(476970854, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique",
                "Boomsma", 456, 7037);
            Relatie relatie3 = new Relatie(420645858, new DateTime(1991, 2, 27), GeslachtType.Vrouw, "Chantal",
                "Mijndertsma", 789, 7029);

            RelatieCollection relatieList = new RelatieCollection();
            relatieList.Add(relatie1);
            relatieList.Add(relatie2);
            relatieList.Add(relatie3);

            for (int i = 0; i < relatieList.Count; i++)
            {
                Console.WriteLine("Naam van de relatie is {0}", relatieList[i].VolledigeNaam);
            }

            Console.ReadKey();
        }

        public static void Exercise2()
        {

            int[] relatieNummers = new int[] { 123, 456, 789 };

            Relatie relatie1 = new Relatie(194602874, new DateTime(1975, 9, 3), GeslachtType.Man, "John", "Bakker", relatieNummers[0], 7029);
            Relatie relatie2 = new Relatie(476970854, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Boomsma", relatieNummers[1], 7037);
            Relatie relatie3 = new Relatie(420645858, new DateTime(1991, 2, 27), GeslachtType.Vrouw, "Chantal", "Mijndertsma", relatieNummers[2], 7029);
            
            Console.WriteLine("Gebruik in de Relaties collection");

            RelatiesDict relatiesDict = new RelatiesDict();

            relatiesDict.Add(relatie1.Nummer, relatie1);
            relatiesDict.Add(relatie2.Nummer, relatie2);
            relatiesDict.Add(relatie3.Nummer, relatie3);

            //foreach (DictionaryEntry relatieInDict in relatiesDict)
            //{
            //    Console.WriteLine("Naam van de relatie is {0}", ((Relatie)relatieInDict.Value).VolledigeNaam);
            //}
            for (int i = 0; i <= relatieNummers.GetUpperBound(0); i++)
            {
                int nummer = relatieNummers[i];  
                Relatie naam = relatiesDict[nummer]; 
                Console.WriteLine("Naam van de relatie is {0}", naam.VolledigeNaam);
            }

            Console.WriteLine("Aantal elementen in de Dictionary = {0}", relatiesDict.Count);

            relatiesDict.Remove(relatie2.Nummer);

            Console.WriteLine("Aantal elementen in de Dictionary = {0}", relatiesDict.Count);

            Console.ReadKey();

        }
    }

}
