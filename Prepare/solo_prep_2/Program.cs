using System;

namespace solo_prep_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for a percentage grade.
            Console.Write("Enter a grade: ");
            float grade = float.Parse(Console.ReadLine());

            string letter;
            
            // If statements to determine different letter
            // grades based on the percentage grade.
            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
            // While loop to ensure the user enters
            // a positive value.
            while (grade < 0)
            {
                Console.WriteLine("Invalid input. Grade must be positive.");
                Console.Write("Enter a grade: ");
                grade = float.Parse(Console.ReadLine());
            }

            string sign;

            // If statements to determine whether to add a sign to the grade.
            if (grade % 10 < 3)
            {
                sign = "-";
            }
            else if (grade % 10 > 7)
            {
                sign = "+";
            }
            else
            {
                sign = "";
            }

            if (grade >= 93 || letter=="F")
            {
                sign = "";
            }
            
            // Display the results. If grade is higher than 70, they passed.
            // Otherwise, they failed.
            if (grade >= 70)
            {
                Console.WriteLine($"\nCongratulations! You passed with a letter grade of {letter}{sign}");
            }
            else
            {
                Console.WriteLine($"\nUnfortunately you didn't pass. Your letter grade is {letter}{sign}. You'll do well next time :)");
            }
        }
    }
}