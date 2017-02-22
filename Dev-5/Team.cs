using System.Collections.Generic;

namespace Dev_5
{
    class Team
    {
        public void Creater(List<Employee> AllEmployees)
        {
            AllEmployees.Add(new Employee("Junior", 500, 20));
            AllEmployees.Add(new Employee("Middle", 1000, 50));
            AllEmployees.Add(new Employee("Senior", 1500, 90));
            AllEmployees.Add(new Employee("Lead", 2000, 110));
        }
    }
}
