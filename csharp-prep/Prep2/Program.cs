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
            Console.Write("You received an A");
        }
        else if (percentage >= 80)
        {
            Console.Write("You received a B");
        }
        else if (percentage >= 70)
        {
            Console.Write("You received a C");
        }
        else if (percentage >= 60)
        {
            Console.Write("You received a D");
        }
        else
        {
            Console.Write("You received an F");
        }
    }
}