using System;

namespace Metod1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv två heltal för att få fram arean på en rektangel");
            Console.Write("Tal 1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal 2: ");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Arean för rektangel med sidorna {tal1} och {tal2} blir {Area(tal1, tal2)}");
        }

        static double Area(int tal1, int tal2)
        {
            return tal1 * tal2;
        }

    }
}