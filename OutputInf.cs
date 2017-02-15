using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserConsole1
{
    class OutputInf
    {
        public static void PrintAllStudent(ArrayList al)
        {
            foreach (var item in al)
            {
                User p = (User)item;
                Console.WriteLine(p.ToString());
            }
        }
        public static void PrintMessage()
        {
            Console.WriteLine("Для добавления студента нажмите на 1");
            Console.WriteLine("Для получения списка нажмите на 2");
            Console.WriteLine("Для получения AveregeAge нажмите на 3");

        }

        public static void AveregeAge(ArrayList al)
        {
            int sumAge=0, count=0;
            double avAge;
            foreach (var item in al)
            {
                User p = (User)item;
                sumAge += p.age;
                count++;
            }
            avAge = Convert.ToDouble(sumAge/count);
            Console.WriteLine(avAge);
        }
        
            public static void OldestUser(ArrayList al)
        {
            int mAge = 0;
            User max = new User();
            foreach (var item in al)
            {
                User p = (User)item;
                if (mAge < p.age)
                {
                    mAge = p.age;
                    max = p;
                }
            }
            
            Console.WriteLine(max.ToString());
        }
        public static void PopularWomanName(ArrayList al)
        {
            int currentPopularCount = 0;
            int maxPopularCount = 0;
            int mAge = 0;
            string popularName = null;
            string currentName = null;
            User max = new User();
            foreach (var item in al)
            {
                User p = (User)item;
                if (p.sex == "f")
                {
                    currentName = p.name;
                    if (currentName != p.name)
                    {
                        currentName = p.name;
                        currentPopularCount++;
                        if (currentPopularCount > maxPopularCount)
                        {
                            maxPopularCount = currentPopularCount;
                            popularName = currentName;
                        }
                    }
                    else
                    {
                        currentPopularCount++;
                    }
                }
            }
            
            Console.WriteLine(max.ToString());
        }
    }
}
