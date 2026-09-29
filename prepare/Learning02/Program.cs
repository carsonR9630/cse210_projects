using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Zookeeper";
        job1._company = "Tautphaus Park Zoo";
        job1._startYear = 2006;
        job1._endYear = 2010;
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Magician";
        job2._company = "Magic Palace";
        job2._startYear = 2010;
        job2._endYear = 2016;
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "George Smith";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        Console.WriteLine(myResume._jobs[0]._jobTitle);
    }
}