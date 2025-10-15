using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class Chapter13
    {
        public static void Exercise1()
        {
            var relatie1 = new Relatie(194602874, new DateTime(1975, 9, 3), GeslachtType.Man, "John", "Bakker");
            var relatie2 = new Relatie(420645858, new DateTime(1991, 2, 27), GeslachtType.Vrouw, "Chantal", "Mijndertsma");
            var relatie3 = new Relatie(476970854, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Boomsma");

  
            var relaties = new RelatieCollectionEvent<Relatie>();

  
            relaties.Changed += new ChangedEventHandler(RelatiesChanged);
            relaties.Changed += new ChangedEventHandler(RelatiesChanged);

            relaties.Add(relatie1);   
            relaties.Add(relatie2);   
            relaties.Remove(relatie1);

            Console.ReadKey();
        }
        private static void RelatiesChanged(object sender, string verbijzondering)
        {
            Console.WriteLine($"[Changed] ：{verbijzondering}");
        }

        public static void Exercise2()
        {
            var relatie1 = new Relatie(194602874, new DateTime(1975, 9, 3), GeslachtType.Man, "John", "Bakker");
            var relatie2 = new Relatie(420645858, new DateTime(1991, 2, 27), GeslachtType.Vrouw, "Chantal", "Mijndertsma");
            var relatie3 = new Relatie(476970854, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Boomsma");


            var relaties = new RelatieCollectionEvent<Relatie>();


            relaties.Changed += new ChangedEventHandler(RelatiesChanged);


            relaties.Add(relatie1);
            relaties.Add(relatie2);
            relaties.Remove(relatie1);

            relaties.Changed -= new ChangedEventHandler(RelatiesChanged);
            relaties.Remove(relatie2);
            relaties.Add(relatie3);
            Console.ReadKey();
        }
        public static void Exercise3()
        {
            var relatie1 = new Relatie(194602874, new DateTime(1975, 9, 3), GeslachtType.Man, "John", "Bakker");
            var relatie2 = new Relatie(420645858, new DateTime(1991, 2, 27), GeslachtType.Vrouw, "Chantal", "Mijndertsma");
            var relatie3 = new Relatie(476970854, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Boomsma");

            var relaties = new RelatieCollectionEvent<Relatie>();
            
            relaties.EvenCount +=new CountEventHandler(RelatiesEvenCount);
            relaties.OddCount += new CountEventHandler(RelatiesOddCount);

            //relaties.EvenCount += (sender, count) =>
            //    Console.WriteLine($"evenCount：{count}");
            //relaties.OddCount += (sender, count) =>
            //    Console.WriteLine($"oodCount：{count}");

            relaties.Add(relatie1);
            relaties.Add(relatie2);
            relaties.Remove(relatie2);
            relaties.Add(relatie2);
            relaties.Add(relatie3);
            relaties.Remove(relatie3);


            Console.ReadKey();
        }
        private static void RelatiesEvenCount(object sender, int count)
        {
            Console.WriteLine($"er is even aantal relaties：{count}");
        }

        private static void RelatiesOddCount(object sender, int count)
        {
            Console.WriteLine($"er is oneven aantal relaties：{count}");
        }

        public static void Exercise4()
        {
            var relatie1 = new Relatie(194602874, new DateTime(1975, 9, 3), GeslachtType.Man, "John", "Bakker");
            var relatie2 = new Relatie(420645858, new DateTime(1991, 2, 27), GeslachtType.Vrouw, "Chantal", "Mijndertsma");
            var relatie3 = new Relatie(476970854, new DateTime(1985, 8, 11), GeslachtType.Vrouw, "Monique", "Boomsma");

            var relaties = new RelatieCollectionEvent1<Relatie>();

            relaties.Changed += new EventHandler<ChangedEventArgs>(RelatiesChanged);
            relaties.CountChanged += new EventHandler<CountEventArgs>(RelatiesAantal);

            relaties.Add(relatie1);
            relaties.Add(relatie2);
            relaties.Remove(relatie2);
            relaties.Add(relatie2);
            relaties.Add(relatie3);
            relaties.Remove(relatie3);
        }
        
        private static void RelatiesChanged(object sender, EventArgs e)
        {
            var args = e as ChangedEventArgs;
            if (args != null)
            {
                Console.WriteLine($"Wijziging : {args.Verbijzondering}" );
            }
        }

        private static void RelatiesAantal(object sender, EventArgs e)
        {
            var args = e as CountEventArgs;
            if (args != null)
            {
                Console.WriteLine($"huidige aantal relaties {args.Count} en het is een  {(args.IsEven ? "even" : "oneven")}.");
            }
        }
    }
}



