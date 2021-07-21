using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomOrderConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRandomOrderOfnNumber();
        }

        private static void PrintRandomOrderOfnNumber()
        {
            Console.WriteLine("Enter a positive integer:");
            var s = Console.ReadLine();
            if (!uint.TryParse(s, out uint n))
                Console.WriteLine("Invalid number, Please try again.");
            else
            {
                var randomOrder = GetRandomOrderofnNumber(n);
                Console.WriteLine($"Random order of {n} numbers:");
                foreach (var item in randomOrder)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Do you want to try again? y/n?");
            var response = Console.ReadLine();
            if (response == "y")
                PrintRandomOrderOfnNumber();
        }

        /// <summary>
        /// Gets a list of random order of n numbers
        /// </summary>
        /// <param name="n">Accepts a positive 32-bit integer</param>
        /// <returns>A list of random order of n numbers</returns>
        public static IEnumerable<int> GetRandomOrderofnNumber(uint n)
        {
            try
            {
                return Enumerable.Range(0, (int)n).OrderBy(i => Guid.NewGuid());
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
        }
    }
}
