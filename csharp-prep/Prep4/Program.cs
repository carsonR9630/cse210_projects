using System;

class Program
{
    static void Main(string[] args)
    {
        // Create list
        List<int> numbers = new List<int>();
        int userNumber = -1;

        // Instructions for user
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop to get numbers in list
        do
        {
            Console.Write("Enter Number: ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while(userNumber != 0);

        // get the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // get the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

    }
}