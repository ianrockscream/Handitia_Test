using System;
using System.Collections.Generic;
using System.Text;

namespace Handitia_Test.Logic
{
    public class OutputHandler : MultipleBy
    {
        public string Output(int value)
        {
            string output = string.Empty;
            if (MultipleBy3(value))
                output = "Fizz";
            if (MultipleBy5(value))
            {
                if (!string.IsNullOrEmpty(output))
                    output = $"{output}Buzz";
                else
                    output = "Buzz";
            }
            if (string.IsNullOrEmpty(output))
                output = $"{value}";
            return output;
        }
    }
}
