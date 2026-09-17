using System.Collections.Generic;
using System.Linq;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int userNumbers;
            
        Console.WriteLine("Enter a positive or negative number, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumbers = int.Parse(userInput);

            if (userNumbers != 0)
            {
                numberList.Add(userNumbers);
            }
        } while (userNumbers != 0);

        // Using loops for operation
        // Computing the sum
        int sum = 0;
        foreach (int number in numberList)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Find the average
        float average = ((float)sum) / numberList.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the max
        int max = numberList[0];

        foreach (int number in numberList)
        {
            if (number > max)
            {
                max = number;
            }
        }
        
        Console.WriteLine($"The max is: {max}");

        /* Using Methods to compute the operations
        int sum = numberList.Sum();
        double average = numberList.Average();
        int max = numberList.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        */

        int min = int.MaxValue;
        foreach (int number in numberList)
        {
            if (number > 0 && number < min)
            {
                min = number;
            }
        }

        Console.WriteLine($"The smallest positive number is: {min}");


        // Sorting the list
        numberList.Sort();
        Console.WriteLine("You sorted list is: ");
        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }
    }
}