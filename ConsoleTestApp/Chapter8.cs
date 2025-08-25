using System;

namespace ConsoleTestApp;

public class Chapter8
{
    public static void Exercise1()
    {
        Persoon1 persoon = new Persoon1();
        persoon.Geslachtsnaam = "Polo";
        persoon.Burgerservicenummer = 123456789;
        Console.WriteLine(persoon.GeefDetails());
        Console.ReadLine();
    }

    public static void Exercise2()
    {
        Persoon2 persoon2 = new Persoon2("Marko", 987654321);
        Console.WriteLine(persoon2.GeefDetails());
        Console.ReadKey();
    }

    public static void Exercise3()
    {
        Persoon3 persoon3 = new Persoon3("Hana",112233445
            ,new DateTime(1999,09,09));
        Console.WriteLine(persoon3.GeefDetails());
    }

    public static void Exercise5()
    {
        Persoon5 persoon = new Persoon5
        {
            Voornaam = "Darth",
            Achternaam = "Vader",
            Geboortedatum = new DateTime(1999, 9, 19)
        };

        Werknemer werknemer = new Werknemer()
        {
            Voornaam = "Bob",
            Achternaam = "Dylan",
            Geboortedatum = new DateTime(1985, 3, 20),
            DatumInDienst = new DateTime(2025, 8, 10)
        };
        Console.WriteLine(persoon);
        Console.WriteLine(werknemer);
    }

    public static void Exercise6()
    {
        Persoon6 persoon = new Persoon6
        {
            Voornaam = "David",
            Achternaam = "Bowie",
            Geboortedatum = new DateTime(1999, 9, 19)
        };

        Werknemer6 werknemer = new Werknemer6()
        {
            Voornaam = "Mark",
            Achternaam = "Polo",
            Geboortedatum = new DateTime(1985, 3, 20),
            DatumInDienst = new DateTime(2025, 8, 10)
        };
        Console.WriteLine(persoon);
        Console.WriteLine(werknemer);
    }
    public static void Exercise7()
    {
        IPersoon7 persoon = new Persoon7
        {
            Voornaam = "Donald",
            Achternaam = "Trump",
            Geboortedatum = new DateTime(1966, 6, 16)
        };
        
        Console.WriteLine(persoon);
    }

   

}



    



