using System;

namespace CSharpFundamentals
{
    class BasicDates
    {
        public static void Run()
        {
            Console.WriteLine("Let's date stuff...");
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(dateTime);
            Console.WriteLine(now);
            Console.WriteLine(today);

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(); 
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());

            Console.WriteLine(); 
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine();
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
