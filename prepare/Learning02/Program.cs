using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Lego modeler";
        job1._company = "Lego";
        job1._startYear = 2018;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Robotics";
        job2._company = "Vex";
        job2._startYear = 2023;
        job2._endYear = 2050;

        Resume myResume = new Resume();
        myResume._name = "Braxton Keyes";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}