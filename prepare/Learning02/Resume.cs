using System;

public class Resume
{
    public string _nameOfPerson;
    public List<Job> _jobList = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_nameOfPerson}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobList)
        {
            job.DisplayJobDetails();
        }
    }
}
