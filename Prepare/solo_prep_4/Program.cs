using System;
using System.Collections.Generic;

namespace solo_prep_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize "numbers" array.
            List<float> numbers = new List<float>();

            // Declare and initialize "userInput" variable.
            float userInput = 1;

            // While loop that prompts the user to enter a number
            // until they type "0". Add all the numbers to the
            // numbers array.
            while (userInput != 0)
            {
                Console.Write("Enter a number. Enter 0 to quit: ");
                userInput = float.Parse(Console.ReadLine());

                if (userInput != 0)
                {
                    numbers.Add(userInput);
                }
            }

            // Sort the array in ascending order.
            numbers.Sort();

            // Declare and initialize "total" variable.
            float total = 0;

            // Declare and initialize "counter" variable.
            int counter = 0;

            // Declare and initialize "minNum" variable.
            float minNum = 99999999999;

            // For loop to loop through numbers array and make
            // calculations.
            foreach (float number in numbers)
            {
                total += number;
                counter += 1;
                
                if (number > 0 && number < minNum)
                {
                    minNum = number;
                }
            }

            // Calculate average and max values.
            float averageNum = total / counter;
            float maxNum = numbers.Max();

            // Display the results.
            Console.WriteLine();
            Console.WriteLine(string.Format("Sum: {0:0,0.00}", total));
            Console.WriteLine(string.Format("Average: {0:0,0.000}", averageNum));
            Console.WriteLine(string.Format("Largest number: {0:0,0.00}", maxNum));
            Console.WriteLine(string.Format("Smallest positive number: {0:0,0.00}", minNum));
            Console.WriteLine("Sorted list:");
            
            foreach (float number in numbers)
            {
                Console.WriteLine(string.Format("{0:0,0.00}", number));
            }
        }
    }
}