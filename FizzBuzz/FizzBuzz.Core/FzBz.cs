using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.Core
{
    public class FzBz
    {
        public string GetFizzBuzz(int input)
        {
            if (input % 15 == 0) return "FizzBuzz";
            else if ((input % 3) == 0) return "Fizz";
            else if ((input % 5) == 0) return "Buzz";
            return string.Empty;
        }
    }
}
