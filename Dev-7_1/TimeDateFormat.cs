using System.Collections.Generic;
using System.Text;


namespace Dev_7_1
{
    //ToDo: Beauty
    class TimeDateFormat
    {
        TDUnit hour = new TDUnit("HH", 0, 23);
        TDUnit minute = new TDUnit("mm", 0, 59);
        TDUnit second = new TDUnit("ss", 0, 59);
        SeparationMarks timeSeparationMark = new SeparationMarks(":");
        TDUnit day31 = new TDUnit("dd", 1, 31);
        TDUnit month = new TDUnit("MM", 1, 12);
        TDUnit year = new TDUnit("yy", 0, 99);
        SeparationMarks dateSeparationMark = new SeparationMarks("/");
       

        public void Builder(out string format, out Dictionary<string, string> timeDateFormat)
        {
            timeDateFormat = new Dictionary<string, string>();

            timeDateFormat.Add("hours", hour.Format);
            timeDateFormat.Add("minutes", minute.Format);
            timeDateFormat.Add("seconds", second.Format);
            timeDateFormat.Add("day31", day31.Format);
            timeDateFormat.Add("month", month.Format);
            timeDateFormat.Add("year", year.Format);
            timeDateFormat.Add("timeSeparationMark", timeSeparationMark.Format);
            timeDateFormat.Add("dateSeparationMark", dateSeparationMark.Format);


            StringBuilder sb = new StringBuilder();
            sb.Append(timeDateFormat["hours"] + timeDateFormat["timeSeparationMark"]);
            sb.Append(timeDateFormat["minutes"] + timeDateFormat["timeSeparationMark"]);
            sb.Append(timeDateFormat["seconds"] + " ");
            sb.Append(timeDateFormat["day31"] + timeDateFormat["dateSeparationMark"]);
            sb.Append(timeDateFormat["month"] + timeDateFormat["dateSeparationMark"]);
            sb.Append(timeDateFormat["year"]);
            format = sb.ToString();
        }
    }
}
