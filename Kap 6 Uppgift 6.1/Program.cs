using System;
namespace Uppgift6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Addera(4, 5, 6));
            Console.WriteLine(Addera(4,123));
        }

        static int Addera(int a = 0, int b = 0, int c = 0)
        {
            return a + b + c;
        }
    }
}
/*Skapa ett program som innehåller metoden
static int Addera(int tal1, int tal2, int tal3)
Metoden ska addera och returnera summan av de tre talen.*/