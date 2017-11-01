using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Deliverable8_Lab16_PrimeNumbersTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37,
                                   41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83,
                                   89, 97, 101, 103, 107, 109, 113, 127, 131,
                                   137, 139, 149, 151, 157, 163, 167, 173, 179,
                                   181, 191, 193, 197, 199 };

            Console.WriteLine("/***************************************/");
            Console.WriteLine("/* Welcome to the Primo Primaries v1.0 */");
            Console.WriteLine("/***************************************/");

            Console.WriteLine();
            Console.WriteLine("Let's locate some primes!");
            Console.WriteLine();
            Console.WriteLine("This program will find you any prime number, in order, from first prime number on.");
            Console.WriteLine($"There are currently {primeNumbers.Length} numbers in the PrimesDB.");

            bool continueStatus = true;
            while (continueStatus)
            {
                Console.Write("Which prime number are you looking for? : ");
                int n;
                bool valid = int.TryParse(Console.ReadLine(), out n);

                if (!valid || n < 1 || n > primeNumbers.Length)
                {
                    Console.WriteLine("Oops! It looks like that entry is invalid.");
                    Console.Write("Do you want to find another prime number? (y/n): ");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        continueStatus = true;
                    }
                    else
                    {
                        continueStatus = false;
                    }
                }
                else
                {
                    Console.WriteLine(PrimeNumLookUp(primeNumbers, n));
                    Console.Write("Do you want to find another prime number? (y/n): ");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        continueStatus = true;
                    }
                    else
                    {
                        continueStatus = false;
                    }
                }
            }

            Console.WriteLine("Good Bye!");
        }

        public static string PrimeNumLookUp (int[] primeNumbers, int n)
        {
            return "The number " + n + " prime is " + primeNumbers[n - 1];
        }
    }
}
