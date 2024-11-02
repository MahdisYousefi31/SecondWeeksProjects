using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahdis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
    }
}

