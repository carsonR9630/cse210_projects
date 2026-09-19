using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueInText = Console.ReadLine();

        // Converts the string to an integer
        int percentage = int.Parse(valueInText);

        if (percentage >= 90)
        {
            Console.WriteLine("You received an A");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("You received a B");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("You received a C");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("You received a D");
        }
        else
        {
            Console.WriteLine("You received an F");
        }

        // if else statements to determine if course was passed
        if (percentage >= 70)
        {
            Console.Write("You passed the class. Congratulations!");
        }
        else
        {
            Console.Write("You did not pass the class. Try again, you can do this!");
        }
    }
}