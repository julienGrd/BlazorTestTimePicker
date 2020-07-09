using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTestTimePicker.Shared
{
    public static class TimespanExtension
    {
        public static DateTime ToDateTime(this TimeSpan source)
        {
            return DateTime.Now.Date + source;
        }

        public static TimeSpan RoundToNearestMinutes(this TimeSpan input, int minutes)
        {
            var totalMinutes = (int)(input + new TimeSpan(0, minutes / 2, 0)).TotalMinutes;

            return new TimeSpan(0, totalMinutes - totalMinutes % minutes, 0);
        }
    }
}
