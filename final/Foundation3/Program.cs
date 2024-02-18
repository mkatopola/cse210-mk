using System;


class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Sunny Side", "Blantyre", "Southern Region", "Malawi");
        Lecture lecture = new Lecture("Moffat Katopola", 300, "Risk Assessment", "The lecture event will delve into the Risk Assessment procedure and underscore its significance in delivering top-notch service to our clientele.", "15/03/2024", "10:00", address1);

        Address address2 = new Address("Air Wing", "Lilongwe", "Central Region", "Malawi");
        Outdoor outdoor = new Outdoor("Partly cloudy, Temp: ~28°C, Wind: South at 12 mph with gusts up to 27 mph", "Cycling", "This event is designed to gather funds that will aid in building a new Pediatric Ward at the Air Wing Community Hospital in Lilongwe.", "25/04/2024", "08:40", address2);

        Address address3 = new Address("Old Naisi", "Zomba", "Eastern Region", "Malawi");
        Receptions receptions = new Receptions("reservations@events.com", "Wedding Anniversary", "This occasion is dedicated to honoring the 25th wedding anniversary of Mr. and Mrs. Katopola.", "30/10/2023", "14:00", address3);

        if (System.Console.IsOutputRedirected)
        {
            Console.WriteLine("This program requires a console window to run correctly.");
            Environment.Exit(1);
        }
        else
        {
            Console.Clear();
        }
        {
            Console.WriteLine("*** WELCOME TO THE EVENTS PLANNER PROGRAM ***\n");
            Console.WriteLine("Here are the planned events so far:");
            Console.WriteLine("============================================================================================");
            Console.WriteLine();
            Console.WriteLine(lecture.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(lecture.FullDetails());
            Console.WriteLine();
            Console.WriteLine(lecture.ShortDescription());
            Console.WriteLine();
            Console.WriteLine("============================================================================================");
            Console.WriteLine();

            Console.WriteLine(outdoor.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(outdoor.FullDetails());
            Console.WriteLine();
            Console.WriteLine(outdoor.ShortDescription());
            Console.WriteLine();
            Console.WriteLine("============================================================================================");
            Console.WriteLine();

            Console.WriteLine(receptions.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(receptions.FullDetails());
            Console.WriteLine();
            Console.WriteLine(receptions.ShortDescription());
            Console.WriteLine();
            Console.WriteLine("============================================================================================");
            Console.WriteLine();
        }
    }
}
