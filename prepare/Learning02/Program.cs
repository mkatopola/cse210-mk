using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Adventist Health Services";
        job1._jobTitle = "Intern Laboratory Technician";
        job1._startYear = 2020;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._company = "Ministry of Health";
        job2._jobTitle = "Laboratory Technician";
        job2._startYear = 2021;
        job2._endYear = 2022;

        Job job3 = new Job();
        job3._company = "Ministry of Health";
        job3._jobTitle = "Laboratory Supervisor";
        job3._startYear = 2023;
        job3._endYear = 2024;


        Resume myResume = new Resume();
        myResume._nameOfPerson = "Moffat Katopola";

        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);
        myResume._jobList.Add(job3);
        
        Console.WriteLine();
        myResume.DisplayResumeDetails();
        Console.WriteLine();
    }
}
