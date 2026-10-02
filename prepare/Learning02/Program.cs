using System;

class Program
{
    static void Main(string[] args)
    {
        // jobs

        Job job1 = new Job();
        job1._jobTitle = "Chemical Engineer";
        Job job2 = new Job();
        job2._jobTitle = "Web Designer";
        Job job3 = new Job();
        job3._jobTitle = "Framer";

        // start & end year
        job1._startYear = 2019;
        job1._endYear = 2021;

        job2._startYear = 2022;
        job2._endYear = 2024;

        job3._startYear = 2024;
        job3._endYear = 2026;

        // company
        job1._company = "Koch Industries";
        job2._company = "Tesla";
        job3._company = "Blu-D Construction";

        // add jobs to resume
        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        
        // name
        myResume._name = "Matthew Loveland";
        
        // displays resume
        myResume.DisplayResume();

    }
}