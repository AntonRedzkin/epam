using System;
using System.IO;

namespace Dev_9
{
    class FileReader
    {
        public void FileText(out string filesText)
        {
            Console.WriteLine("Enter file's adress and it's name for example: D:\\name.ini ");
            String filesAdress = Console.ReadLine();
            filesText = File.ReadAllText(@filesAdress);
        }
    }
}
