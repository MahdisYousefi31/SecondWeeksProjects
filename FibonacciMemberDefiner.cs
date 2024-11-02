using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahdis
{
    class fibonaccichecker
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (IsFibonacci(number))
                {
                    Console.WriteLine($"{number} is in the Fibonacci sequence.");
                }
                else
                {


                    Console.WriteLine($"{number} is not in the Fibonacci sequence.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        static bool IsFibonacci(int n)
        {
            return IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4);
        }

        static bool IsPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return (s * s == x);
        }
    }
}