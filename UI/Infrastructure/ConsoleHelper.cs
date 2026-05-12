using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Infrastructure
{
    public static class ConsoleHelper
    {
        public static int GetValidIndex(string prompt, int maxCount)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? "";

                if (!int.TryParse(input, out int value))
                {
                    Console.WriteLine("Error: Please enter a numeric value.");
                    continue;
                }

                if (value < 1 || value > maxCount)
                {
                    Console.WriteLine($"Error: Please enter a number between 1 and {maxCount}.");
                    continue;
                }

                return value - 1;
            }
        }

       public static string GetRequiredString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()?.Trim() ?? "";

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error: This field cannot be empty.");
                    continue;
                }

                return input;
            }
        }
    }
}
