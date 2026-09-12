using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("What is your subject score? ");
        string userScoreInput = Console.ReadLine();
        int grade = int.Parse(userScoreInput);


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

        // Adding + or -
        string sign = "";
        int last_digit = grade % 10;

        if (last_digit >= 7)
        {
            sign = "+";
        }
        else if (last_digit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Handle the A+ grades
        if (grade >= 93)
        {
            sign = "";
        }

        // Handle the F+ and F- grades
        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Stay focused and you'll get it next time!");
        }
    }
}