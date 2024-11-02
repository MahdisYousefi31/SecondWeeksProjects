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
            Console.WriteLine("Please enter only alphabetic. Type 'exit' to quit.");

            while (true)
            {
                string input = Console.ReadLine();

                // Alloe exit command
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                // check if the input is alphabetic
                if (IsAlphabetic(input))
                {
                    Console.WriteLine($"You entered: {input}");
                }
                else
                {
                    Console.WriteLine("Invalid input! Please try again.");
                }
            }
        }

        static bool IsAlphabetic(string input)
        {
            // check if the string is empty
            if (string.IsNullOrEmpty(input))
                return false;

            foreach (char c in input)
            {

                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true; // all characters are letters
        }
    }
}
       