using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Console.WriteLine("Welcome to the Scripture memorization Program!");
        scripture.LoadScripture();
        scripture.Display();

    }
}