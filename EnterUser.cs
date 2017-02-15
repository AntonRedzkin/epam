using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserConsole1
{
    class EnterUser
    {
        public static void inputUserData(ArrayList a)
        {
            string newname, newsurname, newsex; int newage;
            Console.WriteLine("Enter User's name: ");
            newname = Console.ReadLine();
            Console.WriteLine("Enter User's surname: ");
            newsurname = Console.ReadLine();
            Console.WriteLine("Enter User's sex: ");
            newsex = Console.ReadLine();
            Console.WriteLine("Enter User's age: ");
            newage = int.Parse(Console.ReadLine());

            a.Add(new User { name = newname, surname = newsurname, sex= newsex, age= newage });

        }
    }
}
