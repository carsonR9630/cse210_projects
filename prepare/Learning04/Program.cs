using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("George Washington", "PE");
        Console.WriteLine(a1.GetSummary());
        
        MathAssignment a2 = new MathAssignment("Ben Franklin", "Quadrinomials", "2.5", "9-20");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Shelly", "Creative Writing", "Frankenstien");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}