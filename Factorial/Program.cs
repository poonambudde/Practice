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
            for (int i = 1; i <= a; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
