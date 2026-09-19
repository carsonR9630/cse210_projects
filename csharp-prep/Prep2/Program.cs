using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueInText = Console.ReadLine();
        string letter = "";

        // Converts the string to an integer
        int percentage = int.Parse(valueInText);

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        // Grade received
        Console.WriteLine($"Your letter grade is {letter}");

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