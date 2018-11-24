using System;

namespace CSharpFundamentals
{
    class BasicTimeSpan
    {
        public static void Run()
        {
            Console.WriteLine("Let's timespan stuff...");
            var timeSpan = new TimeSpan(1, 2, 3);
            var oneHour = new TimeSpan(1, 0, 0); // not super readable...
            oneHour = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add and Subtract
            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString
            string stringTimeSpan = timeSpan.ToString();
            Console.WriteLine(stringTimeSpan);

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
