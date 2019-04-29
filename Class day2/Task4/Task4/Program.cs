using System;
using System.Collections.Generic;

namespace Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        { 
            DateTime StartDate = new DateTime(2019, 4, 15);
            DateTime EndDate = new DateTime(2019, 4, 28);
            double numberOfdays = (EndDate - StartDate).TotalDays;
            double numberOfweeks = (EndDate - StartDate).TotalDays / 7;
            var totalDays = 0;
            for (var date = StartDate; date < EndDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek != DayOfWeek.Saturday
                    && date.DayOfWeek != DayOfWeek.Sunday
                    && date.DayOfWeek != DayOfWeek.Friday)
                    totalDays++;
            }
            Console.WriteLine("Diff between days: {0}", numberOfdays);
            Console.WriteLine("Diff between days without in weeks {0}", numberOfweeks);
            Console.WriteLine("Diff between days without weekends and Friday: {0}", totalDays);
        }
    }

}
