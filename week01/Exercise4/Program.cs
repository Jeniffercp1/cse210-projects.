using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        int largestNumber = numbers[0];
        int smallestPositiveNumber = 0;

        foreach (int currentNumber in numbers)
        {
            sum += currentNumber;

            if (currentNumber > largestNumber)
            {
                largestNumber = currentNumber;
            }

            if (currentNumber > 0)
            {
                if (smallestPositiveNumber == 0 || currentNumber < smallestPositiveNumber)
                {
                    smallestPositiveNumber = currentNumber;
                }
            }
        }

        double average = ((double)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average.ToString(CultureInfo.InvariantCulture)}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");

        numbers.Sort();

        Console.WriteLine("The sorted list is:");

        foreach (int currentNumber in numbers)
        {
            Console.WriteLine(currentNumber);
        }
    }
}
