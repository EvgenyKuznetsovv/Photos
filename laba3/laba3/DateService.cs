using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{
    public class DateService
    {
        public static void GetDay(string value)
        {
            DateTime date = DateTime.Parse(value);
            Console.WriteLine(date.DayOfWeek);
            
        }

        public static int  GetDaysSpan(int day, int month, int year)
        {
            DateTime date1 = new DateTime(year, month, day); // дата передаваемая методу 
            TimeSpan span;
             
            if (date1 > DateTime.UtcNow)
            {
                span = date1.Subtract(DateTime.UtcNow);
            }
            else
            {
                span = DateTime.UtcNow - date1;
            }

            return span.Days;
        }

    }
}
