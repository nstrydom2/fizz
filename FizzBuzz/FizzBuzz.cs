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

        /// <summary>
        /// Checks if a given number is divisble by 5
        /// </summary>
        /// <param name="num">integer to verify multiple of 5</param>
        /// <returns>boolean value</returns>
        public bool IsDivisibleBy5(int num)
        {
            return num % 5 == 0;
        }

        public void IterFizzBuzz(int num)
        {
            // TODO implement a method that loops from 1 to the target num
        }
    }
}
