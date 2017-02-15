using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserConsole1
{
    class User
    {
        public string name;
        public string surname;
        public string sex;
        public int age;
        public override string ToString()
        {
            return string.Format(" Name:{0}, Surname:{1}, Sex:{2}, Age:{3}", name, surname, sex, age);
        }

    }
}
