using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_4
{
    class AddText
    {
        string spaceText, nospaceText;
        public void AddNewText(List<String> NewText, List<String> DevText)
        {
            Console.WriteLine("Enter Text: ");
            spaceText = Console.ReadLine();
            nospaceText = RemoveSpaces(spaceText);
            NewText.Add(spaceText);
            DevText.Add(nospaceText);
            foreach (string item in NewText)
            {
                Console.WriteLine(item);
            }
        }

        // Search predicate returns true if a string ends in "saurus".
        private string RemoveSpaces(string inputString)
        {
            inputString = inputString.Replace("  ", string.Empty);
            inputString = inputString.Trim().Replace(" ", string.Empty);
            return inputString;
        }
    }
}
