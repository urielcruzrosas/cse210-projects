        /*
 * Program: Grade Calculator
 * Author: Uriel Cruz
 */

using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("What is your grade percentage (only numbers)? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

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

        // Extra Step 1: Create + or - letter grades
        string sign = "";
        int remainder = grade % 10;

        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Extra Step 2 and 3: Recognize A as just A= and F as non symbol
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        if (grade == 100)
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Core requirement 2:
        if (grade >= 70)
        {
            Console.WriteLine("You pass the course!");
        }
        else
        {
            Console.WriteLine("Try again to pass");
        }
    }
}