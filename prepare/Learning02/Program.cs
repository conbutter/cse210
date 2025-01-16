using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Nintendo";
        job1._startYear = 2003;
        job1._endYear = 2017;

        Job job2 = new Job();
        job2._jobTitle = "UX Designer";
        job2._company = "Arrowhead Game Studios";
        job2._startYear = 2018;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Harmond Row";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}