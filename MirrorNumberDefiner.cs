using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Mahdis
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number (n):");
                int n = Convert.ToInt32(Console.ReadLine());
      
            Console.WriteLine("Enter the number (m):");
            int m = Convert.ToInt32(Console.ReadLine());

            if (n > m)
            {
                int temp = n;
                n = m;
                m = temp;
            }

            Console.WriteLine($"mirror numbers between {n} and {m} are:");
            for (int i = n; i <= m; i++)
            {
                if (IsMirrorNumber(i))
                {
                    ;
                }

                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsMirrorNumber(int i)
        {
            throw new NotImplementedException();
        }
        static bool Ismirrornumber(int num)
        {
            string str = num.ToString();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return str == new string(arr);
        }
    }
}    