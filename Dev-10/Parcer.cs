using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Dev_10
{
    class Parcer
    {
        public void FileTextToDictionary(ref int indexOfLine, List<string> fileContents, string classKey, out string classValue)
        {
            int lastIndexOfFile = fileContents.LastIndexOf("}");
            string key = string.Empty;
            string value = string.Empty;
            StringBuilder sb = new StringBuilder();

            for (int i = indexOfLine; i < lastIndexOfFile; i++)
            {
                string line = fileContents[i];
                if (line.Contains(classKey))
                {
                    key = FindKey(line);
                    if (key.Equals(classKey))
                    {
                        value = FindValue(line);
                        indexOfLine = fileContents.IndexOf(line) + 1;
                        i = lastIndexOfFile;
                    }
                }
            }
            classValue = value;
        }

        public string FindKey(string filesString)
        {
            int startQuoteIndex = filesString.IndexOf("\"");
            int countIndex = filesString.IndexOf(":", startQuoteIndex) - startQuoteIndex - 1;
            int endQuoteIndex = filesString.IndexOf("\"", startQuoteIndex + 1, countIndex);
            return BuildString(filesString, startQuoteIndex + 1, endQuoteIndex);
        }

        public string FindValue(string filesString)
        {
            int startIndex = filesString.IndexOf(": ") + 1;
            int startQuoteIndex = filesString.IndexOf("\"", startIndex);
            int endIndex = filesString.IndexOf(",", startIndex);
            if (startQuoteIndex < 0)
            {
                if (endIndex < 0)
                {
                    return BuildString(filesString, startIndex + 1, filesString.Length);
                }
                else
                {
                    return BuildString(filesString, startIndex + 1, filesString.Length - 1);
                }
            }
            else
            {
                endIndex = filesString.IndexOf("\"", startQuoteIndex + 1);
                return BuildString(filesString, startQuoteIndex + 1, endIndex);
            }
        }

        public string BuildString(string filesText, int startIndexOfValue, int endIndexOfValue)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = startIndexOfValue; i < endIndexOfValue; i++)
            {
                sb.Append(filesText[i]);
            }
            return sb.ToString();
        }
    }
}
