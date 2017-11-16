using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    class DateModifier
    {
        public int Days { get; set; }

        public int CalculateDifferenceBetweenDates(string firstDate, string secondDate)
        {
            DateTime firstDt = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime secondDt = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            TimeSpan t = firstDt - secondDt;
            return Math.Abs((int)t.TotalDays);
        }
    }
}
