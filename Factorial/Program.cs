using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int a = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int x = 1; x <= a; x++)
            {
                fact *= x;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}