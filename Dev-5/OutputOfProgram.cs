using System;
using System.Collections.Generic;

namespace Dev_5
{
    class OutputOfProgram
    {
        public void MonetarySum(List<Employee> AllEmployees)
        {
            Console.WriteLine("the required number of employees of each skill to meet customer requirements: ");
            foreach (Employee worker in AllEmployees)
            {
                Console.WriteLine(worker.ToString());
            }
        }
    }
}
