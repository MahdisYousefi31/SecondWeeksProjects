using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mahdis
{
    class program
    {
        static void Main()
        {
            string[] phoneNumbers = {
                "0123456789",
                "0000000000",
                "012345678",
                "1234567890",
                "01234567890",
                "0000001234",
            };

            foreach (var number in phoneNumbers)
            {
                if (IsValidPhoneNumber(number))
                {
                    Console.WriteLine($"valid phone number: {number}");
                }
            }
        }

        static bool IsValidPhoneNumber(string number)
        {
            if (Regex.IsMatch(number, @"0\d{9}$"))
            {
                var distinctDigits = new HashSet<char>(number);
                return distinctDigits.Count >= 2;
            }

            return false;
        }
    }
}

