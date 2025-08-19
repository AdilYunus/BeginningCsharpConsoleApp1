using System.Runtime.Intrinsics.Arm;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleTestApp;

public class Chapter6
{
    public static void Exercise1()
    {
        {
            int[] waarden = new[] { 1, 3, 5, 6, 7 };

            long resultaat = Multiply(waarden);

            Console.WriteLine("Het totaal is {0}", resultaat);

            Console.ReadKey();
        }

    }

    private static long Multiply(int[] lijst)

    {
        long multiplying = 1;

        foreach (int waarde in lijst)
        {
            multiplying *= waarde;
        }

        return multiplying;

    }

    public static void Exercise2(int een, int twee)
    {
        long resultaat = MultiplyTweeAgs(een, twee);
        Console.WriteLine($"het resultaat is : {resultaat}");
    }

    private static long MultiplyTweeAgs(int eersteNummer, int tweedeNummer)
    {
        long resultaat = eersteNummer * tweedeNummer;
        return resultaat;
    }

    public static void Exercise3()
        // 2 minimum arguments are required.
    {
        string result = GetWord("De kat krabt de krullen van de trap.", 2, 4, 7);

        Console.WriteLine($"The word is '{result}'");

        Console.ReadKey();
    }

    private static string GetWord(string sentence, params int[] position)
    {
        string result = string.Empty;

        string[] words = sentence.Split(' ');
        //Console.WriteLine(string.Join("", words));

        foreach (int index in position)
        {
            if (result != string.Empty)
            {
                result += ", ";
            }

            result += words[index];
        }

        return result;
        // krabt, krullen, trap.

    }

    public static void Exercise4()

    {
        int[] waarden = new[] { 1, 3, 5, 6, 7 };

        long resultaat = Optellen(waarden);

        Console.WriteLine($"Het totaal is {resultaat}");

        Console.ReadKey();
    }

    private static long Optellen(params int[] lijst)
    {
        long optelling = 0;

        foreach (int waarde in lijst)
        {
            optelling += waarde; ;
        }

        return optelling;
    }

    public static void Exercise5()

    {
        int nummer = 9;
        Add(ref nummer, 3);
        Console.WriteLine($"Nieuwe waarde is {nummer}");
        Console.WriteLine(nummer); // 12
        Add(ref nummer, 8);
        Console.WriteLine(nummer); // 20
        Console.ReadKey();
    }

    private static void Add(ref int waarde, int ophoging)
    {
        waarde += ophoging;
    }

    public static void Exercise6()

    {
        int nummer = 9;
        AddOut(out nummer, 3);
        Console.WriteLine($"Nieuwe waarde is {nummer}");
        Console.WriteLine(nummer);

        AddOut(out nummer, 8);
        Console.WriteLine(nummer);
        Console.ReadKey();
    }

    private static void AddOut(out int waarde, int ophoging)
    {
        waarde = 0;
        waarde += ophoging;
    }

    private static string classString;

    public static void Exercise7()

    {

        string myString = "String defined in Main()";

        classString = "Global string";
        // Ik hoef hier geen Chapter6.myString te gebruiken

        Write7();
        Console.WriteLine("\nNow in Main()");
        Console.WriteLine("Local myString = {0}", myString);
        Console.WriteLine("Global myString = {0}", classString); //hier ook
        Console.ReadKey();

    }
    private static void Write7()

    {
        string myString = "String defined in Write()";
        Console.WriteLine("Now in Write()");
        Console.WriteLine("Local myString = {0}", myString);
        Console.WriteLine("Global myString = {0}", classString); //hier ook

    }

    public static void Exercise8()
    {

        Console.WriteLine("De oppervlakte met gelijke zijden van {0} is {1}", 3, Oppervlakte(3));

        Console.WriteLine("De oppervlakte met ongelijke zijden van {0} bij {1} is {2}", 3, 4, Oppervlakte(3, 4));

        Console.ReadKey();
    }
    private static int Oppervlakte(int zijde)
    {
        return zijde * zijde;
    }
    private static int Oppervlakte(int zijde1,int zijde2)
    {
        return zijde1 * zijde2;
    }
   
    delegate string DoeSomething(string naam);
    public static void Exercise9()
    {
        Console.WriteLine("Wat is het woord:");
        string input = Console.ReadLine();
        Console.WriteLine("Alles in hoofdletters? [ja|nee]");
        bool inHoofdletters = Console.ReadLine().ToLower() == "ja";
        
        if (inHoofdletters)
        {
            DoeSomething actie = new DoeSomething(Hoofdletters);
            input = actie(input);
        }
        else
        {
            DoeSomething actie = new DoeSomething(KleineLetters);
            input = actie(input);
        }

        Console.WriteLine("Het woord is {0}", input);

        Console.ReadKey();
    }
    private static string Hoofdletters(string woord)
    {
        return woord.ToUpper();
    }
    private static string KleineLetters(string woord)
    {
        return woord.ToLower();
    }
}
