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
            return fizz;
        }
    }
}