using System;

namespace Dev_6
{
    public class DateTimeFormatSeter
    {
        public void FormatSeter(string format, out string nowDateTime)
        {
            nowDateTime = DateTime.Now.ToString(format);
        }
    }
}
