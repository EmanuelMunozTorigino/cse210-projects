using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");


        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.WriteLine("Enter numbers numbers ('0' to end): ");
            userNumber = int.Parse(Console.ReadLine());

            // It verify if the number is a positive number but not is neccesary on this assignment.

            /*while (number < 0)
            {
                Console.WriteLine("The number must be a positive number.");
                Console.WriteLine("Enter positive numbers ('0' to end): ");
                number = int.Parse(Console.ReadLine());
            }
            */

            numbers.Add(userNumber);
        }
        int total = 0;
        int maxNumber = numbers[0];
        int smallestNumber = 9999999;
        foreach (int num in numbers)
        {
            total = total + num;

            // Look for the max number on the list..
            if (num > maxNumber)
            {
                maxNumber = num;
            }

            // Look for the smallest number on the list
            else if (num > 0)
            {
                if (num < smallestNumber)
                    smallestNumber = num;
            }
        }

        float average = ((float)total) / numbers.Count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
    }
}