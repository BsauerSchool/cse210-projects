using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "CSR 2";
        job1._company = "AMD";
        job1._startDate = 2019;
        job1._endDate = 2023;

        Job job2 = new Job();
        job2._jobTitle = "CSR 1";
        job2._company = "AMD";
        job2._startDate = 2018;
        job2._endDate = 2019;

        Resume myResume = new Resume();
        myResume._name = "Brendin Sauer";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}