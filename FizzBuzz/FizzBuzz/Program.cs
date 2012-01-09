using System;
using FizzBuzz.Core;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            bool keepGoing = true;
            FzBz fb = new FzBz(); //Constructor
            while (keepGoing)
            {
                Console.WriteLine("Enter a number or X to exit.");
                string input = Console.ReadLine();
                if (input.Trim().ToLower() == "x") { keepGoing = false; continue; }
                int inputAsNumber = 0;
                int.TryParse(input, out inputAsNumber);

                if (inputAsNumber == 0 || inputAsNumber >= 100 || inputAsNumber < 1)
                    Console.WriteLine("Invalid number. Please enter a number between 1 and 100");
                else
                {
                    for (i = 1; i <= inputAsNumber; i++)
                    {
                        var result = fb.GetFizzBuzz(i);
                        if (string.IsNullOrEmpty(result)) continue;
                        Console.WriteLine(string.Format("{0} - {1}", i, result));
                    }
                }
            }
        }
    }
}
