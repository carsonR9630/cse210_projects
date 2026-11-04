using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Animation test");
        //for (int i = 5; i > 0; i--)
       // {
            //Console.Write(i);
           // Thread.Sleep(1000);
            //Console.Write("\b \b");
       // }
        //Console.WriteLine("Done counting");

        List<string> animationStrings = new List<string>();
        animationStrings.Add("N");
        animationStrings.Add("Z");
        //foreach(string s in animationStrings)
       // {
       //     Console.Write(s);
       //     Thread.Sleep(1000);
       //     Console.Write("\b \b");
       // }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if(i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        
    }
}
