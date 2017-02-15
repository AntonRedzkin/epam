using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kones = true;
            ArrayList all = new ArrayList();

            while (kones)
            {
                Console.WriteLine();
                OutputInf.PrintMessage();
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    EnterUser.inputUserData(all);
                }
                else if (a == 2)
                {
                    OutputInf.PrintAllStudent(all);
                }
                else if (a == 3)
                {
                    OutputInf.AveregeAge(all);
                }
                else if (a == 4)
                {
                    OutputInf.OldestUser(all);
                }
                else if (a == 5)
                {
                    OutputInf.PopularWomanName(all);
                }
                else kones = false;
            }
        }
        
    }
}
