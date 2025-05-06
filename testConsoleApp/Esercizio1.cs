using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsoleApp
{
    internal class Esercizio1
    {
        public void FizzBuzz()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 7 == 0 && IsPerfectSquare(i))
                {
                    Console.WriteLine("Paperone");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine("Pippo");
                }
                else if (IsPerfectSquare(i))
                {
                    Console.WriteLine("Pluto");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool IsPerfectSquare(int number)
        {
            if (number < 0)
            {
                return false;
            }

            double sqrt = Math.Floor(Math.Sqrt(number));
            return sqrt * sqrt == number;
        }

    }
}
