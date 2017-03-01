using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> timeDateFormat;
            string format = string.Empty;

            TimeDateFormat timeDateFormater = new TimeDateFormat();
            timeDateFormater.Builder(out format, out timeDateFormat);
            Inputer input = new Inputer();
            TimeDateChecker timeDateChecker = new TimeDateChecker();
            timeDateChecker.CheckFormat(timeDateFormat, format, input.TimeDate(format));
        }
    }
}
