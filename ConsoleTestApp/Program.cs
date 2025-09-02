using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using ConsoleTestApp;
namespace ConsoleTestApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ////Chapter 4
            //Chapter4.Exercises();
            //Console.ReadKey();

            ////chapter 5
            //Chapter5.Exercise1();
            //Chapter5.Exercise2();
            //Chapter5.Exercise3();
            //Chapter5.Exercise4en5();
            //Chapter5.Exercise6();
            //Chapter5.Exercise7();
            //Chapter5.Exercise8();
            //Chapter5.Exercise9();
            //Console.ReadKey();

            ////chapter 6
            //Chapter6.Exercise1();
            //Chapter6.Exercise2(111, 9);
            //Chapter6.Exercise3();
            //Chapter6.Exercise4();
            //Chapter6.Exercise5();
            //Chapter6.Exercise6();
            //Chapter6.Exercise7();
            //Chapter6.Exercise8();
            //Chapter6.Exercise9();
            //Console.ReadKey();

            ////chapter 7
            //Chapter7.Exercise1();


            //Chapter 8
            //Chapter8.Exercise1();
            //Chapter8.Exercise2();
            //Chapter8.Exercise3();

            // Exercise 4
            //PersoonBase kan abstract zijn. Vrijwilliger en Werknemer kunnen Sealed zijn

            //Chapter8.Exercise5();
            //Chapter8.Exercise6();
            //Chapter8.Exercise7();

            //Exercise 8
            //Alle drie klassen kunnen worden geïnstantieerd

            // Exercise 9
            // persoonbase is abstract en kan dus niet geïnstantieerd worden,maar werknemer wel

            // Exercise 10
            // Omdat Deel() static is en dus geen toegang heeft tot de instance-velden _teller en _noemer.

            // Exercise 11
            // de constructor met de meeste parameters,De andere constructors roepen deze aan met : this() om code-duplicatie te vermijden.

            //Chapter 9
            //Chapter9.Test();

            //Chapter9.Exercise1();
            // Exercise 2 
            // new Relatie(7 argument)
            // Relatie(7 args ) : base()
            // RelatieBase(7 args)
            // Relatie(7args) : base

            // Exercise 3 
            // kijk naar RelatieBase

            //// Exercise 4
            //Chapter9.Exercise4();
            ////Exercose 5
            Chapter9.Exercise5();// ToString() in Relatie was called

            /* Chapter 10*/
            //Chapter10.Test();
            Chapter10.Exercise1();
        }
    }
}
