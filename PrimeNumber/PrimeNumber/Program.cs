using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.WriteLine("Number is Prime.");
            }
            else
            {
                Console.WriteLine("Number is not Prime.");
            }
            Console.ReadLine();
        }
    }
}
