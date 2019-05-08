using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private int i;
        string fizz = "Fizz";
        string buzz = "Buzz";

        public FizzBuzz(int i)
        {
            this.i = i;
        }


        public void print(string str)
        {
            Console.WriteLine(str);
        }

        public string calculate()
        {
            if (i < 1 || i > 100) return "Invalid number";
            if (i % 3 == 0 && i % 5 != 0) return fizz;
            if (i % 3 != 0 && i % 5 == 0) return buzz;
            if (i % 3 != 0 || i % 5 != 0) return i.ToString();
            return fizz + buzz;
        }
    }
}