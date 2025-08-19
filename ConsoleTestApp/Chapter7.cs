using System.Diagnostics;

namespace ConsoleTestApp;

public class Chapter7
{
    public static void Exercise1()
    {
        try
        {
            CatchInFunction();
        }
        catch (DivideByZeroException divEx)
        {
            Console.WriteLine("Delen door 0 is niet toegestaan! Waarde2 moet ongelijk aan 0 zijn ({0})", divEx.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Er heeft zich een onbekende fout voorgedaan: {0}", ex.Message);
        }
        finally
        {
            Console.WriteLine("Einde programma");
        }
        Console.ReadKey();
    }

    private static double Deel(double teller, double noemer)
    {
        if (noemer == 0.0)
        {
            throw new DivideByZeroException("Noemer mag niet 0 zijn");
        }
        if (noemer > 500)
        {
            throw new Exception("Noemer mag niet groter zijn dan 500");
        }
        return teller / noemer;
    }

    public static void CatchInFunction()
    {
        double waarde1 = 4.0;

        double waarde2 = 0;

        double resultaat = 0.0;

        resultaat = Deel(waarde1, waarde2);

        Console.WriteLine("Het resultaat van de deling is {0}", resultaat);

    }

}