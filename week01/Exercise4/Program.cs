using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            // Add number to the list if it is not 0
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered");
            return;
        }

        //computing the sum
        int sum = 0;
        foreach (int item in numbers)
        {
            sum += item;
        }
        Console.WriteLine($"The sum is: {sum}");

        double average = ((double)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //finding the largest
        int largest = numbers[0];
        foreach (int item in numbers)
        {
            if (item > largest)
            {
                largest = item;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

        int smallestPositive = int.MaxValue;
        foreach (int item in numbers)
        {
            if (item > 0 && item < smallestPositive)
            {
                smallestPositive = item;
            }
        }
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is:{smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }

    }
}