using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amir.Utils.Helpers
{
    public static class DateTimeHelper
    {
        public static string ToHumanReadable(DateTime dateTime)
        {
            var ts = DateTime.UtcNow - dateTime;

            if (ts.TotalSeconds < 60)
                return $"{ts.Seconds} seconds ago";
            if (ts.TotalMinutes < 60)
                return $"{ts.Minutes} minutes ago";
            if (ts.TotalHours < 24)
                return $"{ts.Hours} hours ago";
            if (ts.TotalDays < 30)
                return $"{ts.Days} days ago";

            return dateTime.ToString("dd MMM yyyy");
        }

        public static bool IsWeekend(DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;
        }

        public static int BusinessDaysBetween(DateTime start, DateTime end)
        {
            int businessDays = 0;
            DateTime current = start;

            while (current < end)
            {
                if (!IsWeekend(current))
                    businessDays++;
                current = current.AddDays(1);
            }

            return businessDays;
        }
    }
}
