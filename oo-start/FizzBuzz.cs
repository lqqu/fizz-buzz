using System;
using System.Collections.Generic;

namespace oo_start
{
    public class FizzBuzz
    {
        private int i;
        string fizz = "Fizz";

        public FizzBuzz(int i)
        {
            this.i = i;
        }


        public void print()
        {
            Console.WriteLine(fizz);
        }

        public string calculate()
        {
            if (i % 3 != 0 || i % 5 != 0) return i.ToString();
            return fizz;
        }
    }
}