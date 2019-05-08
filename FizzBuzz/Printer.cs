using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var number = Console.ReadLine();
                var printer = new FizzBuzz(Convert.ToInt32(number));
                printer.print(printer.calculate());
            }
        }
    }
}