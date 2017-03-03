using System;

namespace Dev_9
{
    class Searcher
    {
        public void FindSection(string filesText, out int startIndexOfSection, out int countIndexOfSection)
        {
            Console.WriteLine("Enter section name: ");
            String sectionName = "[" + Console.ReadLine() + "]";
            startIndexOfSection = filesText.IndexOf(sectionName) + sectionName.Length;
            CheckForSearchException(startIndexOfSection - sectionName.Length, "\nSection Not Found, try once again:");
            countIndexOfSection = filesText.IndexOf("[", startIndexOfSection) - startIndexOfSection-1;
            CheckCountIndexException(countIndexOfSection, filesText, startIndexOfSection);
        }

        public void FindValueByKey(string filesText, int startIndexOfSection, int countIndexOfSection, out int startIndexOfValue, out int endIndexOfValue)
        {
            Console.WriteLine("Enter key name: ");
            String keyName = Console.ReadLine();
            int keyNameIndex = filesText.IndexOf(keyName, startIndexOfSection, countIndexOfSection);
            CheckForSearchException(keyNameIndex, "\nKey Not Found, try once again:");
            endIndexOfValue = filesText.IndexOf("\n", keyNameIndex);
            CheckEndIndexException(endIndexOfValue, filesText);
            startIndexOfValue = filesText.IndexOf("=", keyNameIndex) + 1;
        }

        private void CheckForSearchException(int nameIndex, string s)
        {
            if (nameIndex < 0)
            {
                throw new ArgumentOutOfRangeException("NotFound\n", s);
            }
        }

        private void CheckEndIndexException(int endIndex, string filesText)
        {
            if (endIndex < 0)
            {
                endIndex = filesText.Length;
            }
        }

        private void CheckCountIndexException(int countIndexOfSection, string filesText, int startIndexOfSection)
        {
            if (countIndexOfSection < 0)
            {
                countIndexOfSection = filesText.Length - startIndexOfSection;
            }
            if (countIndexOfSection < 2)
            {
                throw new ArgumentNullException("Empty\n", "\nSection is Empty, try once again:");
            }
        }
    }
}
