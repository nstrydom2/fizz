using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public bool IsDivisibleBy3(int num)
        {
            return num % 3 == 0;
        }

        public bool IsDivisibleBy5(int num)
        {
            // TODO implement a method that returns `true` if the num variable
            // is divisible by 5
            return num % 5 == 0;
        }

        public void IterFizzBuzz(int num)
        {
            for (int i = 0; i < num; i++)
            {
                if (IsDivisibleBy3(i) && IsDivisibleBy5(i))
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (IsDivisibleBy3(i)) { Console.WriteLine("Fizz"); }

                else if (IsDivisibleBy5(i)) { Console.WriteLine("Buzz"); }

                else { Console.WriteLine(i); }
            }
        }
    }
}
