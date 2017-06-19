using System;

namespace AddingMachine
{
    class Program
    {
        /****************************************
         * AddingMachine
         * Developer: Jeff Peterson
         * Date: 06/19/2017
         * Purpose: Add the specified amount of digits together
         * **************************************/
        static void Main(string[] args)
        {
            // Variables
            int answer = 0;
            int numberOfDigits;

            // Ask how many digits we are adding
            Console.WriteLine("Adding Machine");
            Console.WriteLine("By Jeff Peterson\n");

            // Ensure we get a valid number of digits to add
            while (true)
            {
                Console.Write("How many digits are we adding together (limit=99): ");
                numberOfDigits = int.Parse(Console.ReadLine());
                // If the user mistypes, jump back to the beginning of the loop and try again.
                if (numberOfDigits > 99)
                {
                    Console.WriteLine("\nSorry, but your limit is 99 digits to add.  Try again.");
                }
                // Also, we have to add more than 1 number together...
                else if (numberOfDigits < 2)
                {
                    Console.WriteLine("\nSorry, but you can't add just one number.  Try again.");
                }
                else
                {
                    // Good! We have a valid input. Break out and continue.
                    break;
                }
            }

            // TODO: Use a switch() to select different operators.
            // Now to loop to add all the digits!
            for (int i = 0; i < numberOfDigits; i++)
            {
                // Display each digit to add, formatting the input to have a nice, even appearance.
                Console.Write("Digit {0:00}: ", i + 1);
                // Store the input into a temporary buffer, using Parse() to convert string to int.
                int buffer = int.Parse(Console.ReadLine());
                // Accumulate the answer by adding the buffer to itself.
                answer += buffer;
            }

            // Display the result!
            Console.WriteLine("\nThe answer is: {0}", answer);
        }
    }
}
