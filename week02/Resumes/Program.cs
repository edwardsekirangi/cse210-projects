using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft inc";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Amazon inc";
        job2._jobTitle = "Cloud Engineer";
        job2._startYear = 2024;
        job2._endYear = 2025;

        // job1.Display();
        // job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Sekirangi Edward";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Displaytitle();


    }
}
