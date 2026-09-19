using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Amazon";
        job1._startYear = 2017;
        job1._endYear = 2019;
        // Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._jobTitle = "Designer";
        job2._company = "Adobe";
        job2._startYear = 2020;
        job2._endYear = 2025;
        
        // Console.WriteLine(job2._company);

        // Displaying with methods
        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        // Create a Resume Object
        Resume myResume = new Resume();
        myResume._name = "Frank Sinatra";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

//        Console.WriteLine(myResume._jobs[0]._jobTitle);
        myResume.Display();
    }
}