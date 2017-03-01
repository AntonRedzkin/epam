using System.Collections.Generic;


namespace Dev_7_1
{
    class TimeDateChecker
    {
        public void CheckFormat(Dictionary<string, string> timeDateFormat, string format, string inputedTimeDate)
        {
            int mCount = 0;
            string mForm = timeDateFormat["minutes"];
            foreach (char m in format)
            {
                if(m.Equals(mForm[mCount]))
                {
                    
                    mCount++;
                }
                if (mCount > mForm.Length)
                {
                    mCount++;
                }
            }
        }
    }
}
