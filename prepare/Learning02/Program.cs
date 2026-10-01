using System;

class Program
{
    static void Main(string[] args)
    {
        // set first job's details by calling the job class
        Job job1 = new Job();
        job1._jobTitle = "Zookeeper";
        job1._company = "Tautphaus Park Zoo";
        job1._startYear = 2006;
        job1._endYear = 2010;

        // set second job's details by calling the same job class
        Job job2 = new Job();
        job2._jobTitle = "Magician";
        job2._company = "Magic Palace";
        job2._startYear = 2010;
        job2._endYear = 2016;

        Resume myResume = new Resume();
        myResume._name = "George Smith";
        // adds the jobs to the resume's jobs list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();
    }
}