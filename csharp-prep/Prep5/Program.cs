using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        // birthYear set by its function out
        int birthYear;
        PromptUserBirthYear(out birthYear);
        int squared = SquareNumber(userNumber);
        DisplayResult(userName, squared, birthYear);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        // convert to integer
        int favNumber = int.Parse(userInput);
        return favNumber;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        string userInput = Console.ReadLine();
        // convert to integer
        birthYear = int.Parse(userInput);
        // made a return, but fixed it after reading instructions for this function again
    }
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }
    static void DisplayResult(string name, int squared, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
        Console.WriteLine($"{name}, you will turn {2026 - year} this year.");
    }
}