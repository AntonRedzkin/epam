using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dev_10
{
    class FileReader
    {
        public void GetFileContents(List<string> fileContents, string path)
        {
            path = @"D:\config.json";
            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.GetEncoding(1251)))
                {
                    while (sr.Peek() >= 0)
                    {
                        Console.Write((char)sr.Read());
                        fileContents.Add(sr.ReadLine());
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(@"File named {0} not found.", path);
                return;
            }
        }
    }
}
