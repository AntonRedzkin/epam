using System.Collections.Generic;

namespace Dev_5
{
    class Criterion
    {
        public void MaxProductivity(List<Employee> AllEmployees, int monetaryAmount)
        {
            int monetary = 0;
            //TODO: make sort AllEmployees by Salary/Productivity
            while (monetary < monetaryAmount)
            {
                foreach (Employee worker in AllEmployees)
                {
                    worker.Count = monetaryAmount / worker.Salary;
                    monetary = monetary + (worker.Salary * worker.Count);
                }
                monetary = 0;
            } 
        }
        public void MinCost(List<Employee> AllEmployees, int requiredProductivity)
        {
            //TODO: make sort AllEmployees by Productivity/Salary
            while (requiredProductivity > 0)
            {
                foreach (Employee worker in AllEmployees)
                {
                    worker.Count = requiredProductivity / worker.Productivity;
                    requiredProductivity = requiredProductivity - (worker.Productivity * worker.Count);
                }
            }
        }
        public void MinNumberOfEmployees(List<Employee> AllEmployees, int requiredProductivity)
        {
            //TODO: make sort AllEmployees by Productivity
            while (requiredProductivity > 0)
            {
                foreach (Employee worker in AllEmployees)
                {
                    if (worker.Name.Equals("Lead"))
                    {
                        worker.Count = requiredProductivity / worker.Productivity;
                        requiredProductivity = requiredProductivity - (worker.Productivity * worker.Count);
                    }
                }
            }
        }

    }
}
