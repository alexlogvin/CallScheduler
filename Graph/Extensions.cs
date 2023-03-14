using System.Globalization;

using Microsoft.Graph.Models;

namespace CallScheduler
{
    public static class Extensions
    {
        internal const string DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffffffK";

        public static DateTime GetDateTime(this DateTimeTimeZone? dateTimeTimeZone)
        {
            //Temporal work aroun for TimeZone processing exceptions
            return DateTime.ParseExact(dateTimeTimeZone.DateTime, DateTimeFormat, CultureInfo.InvariantCulture);
        }
    }
}
