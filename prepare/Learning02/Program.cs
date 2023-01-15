using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Sistem Engineer";
        job1._company = "Pichincha bank";
        job1._startYear = 2016;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Applyed Technology bs";
        job2._company = "Microsoft";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Matias Villacis";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}