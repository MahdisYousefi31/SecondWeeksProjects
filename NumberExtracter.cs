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
            Console.Write("Please enter some text (only numbers will be extracted):");
            string input = Console.ReadLine();

            string numbers = ExtractNumbers(input);

            Console.WriteLine($"Extracted numbers: {numbers}");
        }

        static string ExtractNumbers(string input)
        {
            char[] chars = input.ToCharArray();
            string result = "";

            foreach (char c in chars)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }
}

