using System;
using System.Runtime.InteropServices;
using ConsoleTestApp;

namespace ConsoleTestApp;

public class Chapter5
{
    private enum WindrichtingType : byte

    {
        Noord = 1,
        Oost = 2,
        Zuid = 3,
        West = 4
    }
    
    public static void Exercise1()
    {
        /* Exercise 5-1 */

        
        bool a = true;
        string ab = Convert.ToString(a);
        Console.WriteLine($"Boolean {a} to string {ab}");

        ab = "false";
        bool b = Convert.ToBoolean(ab);
        Console.WriteLine($"String {ab} to boolean {b}");

    }

    public static void Exercise2()
    {
        int intGetal = 12345;
        long longGetal = intGetal;
        Console.WriteLine($"het longGetal is {longGetal}");

        longGetal = 1234567890;
        intGetal = Convert.ToInt32(longGetal);
        Console.WriteLine($"intGetal is {intGetal}");

    }

    public static void Exercise3()
    {
        WindrichtingType windrichting = WindrichtingType.Noord;
        
        Console.WriteLine($"De windrichting {(byte)windrichting}");
        Console.WriteLine($"De windrichting value naam is '{Convert.ToString(windrichting)}'");
        windrichting = (WindrichtingType)Enum.Parse(typeof(WindrichtingType), "West");
        Console.WriteLine(windrichting);

        // convert a byte to WindrichtingType.
        byte windByte = 2;
        WindrichtingType windFromByte = (WindrichtingType)windByte;
        Console.WriteLine($"Byte waarde {windByte} komt overeen met Windrichting '{windFromByte}'");

        // convert an integer to WindrichtingType.
        int windInt = 4;
        WindrichtingType windFromInt = (WindrichtingType)windInt;
        Console.WriteLine($"Int waarde {windInt} komt overeen met Windrichting '{windFromInt}'");

    }
    public static void Exercise4en5()
        //exercise 5-4 and 5-5
    {
        
        String[] namen = new string[5] {"Trump","Rutte","Elizabeth","Erdogan","Polo"};

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"De naam is '{namen[i]}'");
        }
    }

    private const int MAX = 3;
    public static void Exercise6(){
        //exercise 5-6
        {
            Console.WriteLine($"De huidige datum is {DateTime.Now:yy-MM-dd}");
            Console.WriteLine($"De huidige datum is {DateTime.Now:dd MMMM,yyyy}");
            Console.WriteLine($"De huidige datum is {DateTime.Now:yyyy}");

        }

    }

    public static void Exercise7()
    {
        Console.WriteLine("Voer een willekeurig woord in:");

        string invoer = Console.ReadLine();

       invoer = char.ToUpper(invoer[0]) + invoer.Substring(1).ToLower();

        Console.WriteLine($"De gecorrigeerde invoer is {invoer}" );

        
    }

    public static void Exercise8()
    {
        Console.WriteLine("Voer een willekeurig woord in:");

        string invoer = Console.ReadLine();
        
        Console.WriteLine(invoer.Replace('e', 'E'));

    }
    public static void Exercise9()
    {
        string regel = "May the Force be with you. I'll be back. Life is like a box of chocolates.";
        string[] zinnen = regel.Split('.');
        
        foreach (var zin in zinnen)

        {
            string trimmedZin = zin.Trim();

            if (trimmedZin.Length == 0)
                continue;
            Console.WriteLine($"De zin is: {trimmedZin}");
        }
        
    }

}
    