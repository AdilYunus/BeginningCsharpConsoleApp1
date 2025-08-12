namespace ConsoleTestApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string comparison = string.Empty;

            Console.WriteLine("Vul een getal in:");

            int eersteNr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vul nog een getal in:");

            int tweedeNr = Convert.ToInt32(Console.ReadLine());

            //Exercises 4-1-------------------

            if (eersteNr < tweedeNr)
            {
                comparison = "kleiner dan";
            }
            else
            {
                comparison = (eersteNr == tweedeNr) ? "gelijk aan" : "groter dan";

            }
            Console.WriteLine($"Het eerste nummer is {comparison} het tweede nummer.");

            Console.ReadKey();

            //Exercises 4-2-------------------

            if (eersteNr < tweedeNr)
            {
                comparison = "kleiner dan";
            }

            else if (eersteNr == tweedeNr)
            {
                comparison = "gelijk aan";
            }
            else
            {
                comparison = "groter dan";
            }

            //Exercise 4-3-----------------------

            /* improves code readability, maintainability, and can potentially lead to better performance.*/

            Console.WriteLine("Het eerste nummer is {0} het tweede nummer.", comparison);
            Console.WriteLine($"Het eerste nummer is {comparison} het tweede nummer.");

            Console.ReadKey();

            /* exercise 4-4 --------------*/
            Console.WriteLine("Written out numbers (text):");
            string getalTekst = Console.ReadLine().ToLower();

            string nummer;

            switch (getalTekst)
            {
                case "nul":
                    nummer = "0";
                    break;
                case "een":
                    nummer = "1";
                    break;
                case "twee":
                    nummer = "2";
                    break;
                case "drie":
                    nummer = "3";
                    break;
                case "vier":
                    nummer = "4";
                    break;
                case "vijf":
                    nummer = "5";
                    break;
                default:
                    nummer = "onbekend";
                    break;
            }

            Console.WriteLine($"Het nummer is {nummer}.");
            Console.ReadKey();
            /* Exercise 4-5 -----------*/
            //Het nummer is onbekend

            /* Exercise 4-6--------*/
            for (int i = 0; i <= 10; i++)

            {
                i++;//i wordt nog een keer verhoogd
                // 1,3,5,7,9,11 worden geprint
                Console.WriteLine($"Het nummer is {i}.");
            }

            Console.ReadKey();
        }
    }
}
