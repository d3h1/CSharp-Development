using System;

namespace DateTimesTimeSpace
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime awesomeDate = new DateTime(1974, 12, 21);

            // DAY OF WEEK
            Console.WriteLine("Day of the week: {0}", awesomeDate.DayOfWeek);

            // CHANGING VALUES - DOW
            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine("New Date: {0}", awesomeDate.Date);

            // TIME SPANS - Can be used to define a time
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);

            // CHANGING VALUES - TS
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine("New Time: {0}", lunchTime.ToString());
        }
    }
}

