using System;
using System.Text;

namespace Dev_10
{
    class Outputer
    {
        public void Value(string filesText, int startIndexOfValue, int endIndexOfValue)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = startIndexOfValue; i < endIndexOfValue; i++)
            {
                sb.Append(filesText[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
