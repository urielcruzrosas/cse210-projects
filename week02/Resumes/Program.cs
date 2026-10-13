using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // job1.Display();
        // job2.Display();
        Resume myResume = new Resume();
        myResume._name = "Uriel Cruz";

        myResume._jobs.Add(job1); // this instances convert into the index 0, 1 and so for and so on
        myResume._jobs.Add(job2);

//      Console.WriteLine(myResume._jobs[0]._jobTitle);
        myResume.Display();
        
        // Display the companies on the screen
        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);   
    }
}