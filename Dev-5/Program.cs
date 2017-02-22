using System.Collections.Generic;

namespace Dev_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAXPRODUCTIVITY = 1;
            const int MINSUM = 2;
            const int MINWORKERS = 3;

            List<Employee> AllEmployees = new List<Employee>();
            Team team = new Team(); 
            Criterion Criteria = new Criterion();
            InputOfProgram Input = new InputOfProgram();
            team.Creater(AllEmployees);
            int monetarySum = Input.MonetarySum();
            int requirProductivity = Input.RequirProductivity();
            int ChoiseOfCriteries = Input.SelectCriteria();

            switch (ChoiseOfCriteries)
            {
                case MAXPRODUCTIVITY:
                    Criteria.MaxProductivity(AllEmployees, monetarySum);
                    break;
                case MINSUM:
                    Criteria.MinCost(AllEmployees, requirProductivity);
                    break;
                case MINWORKERS:
                    Criteria.MinNumberOfEmployees(AllEmployees, requirProductivity);
                    break;
            }
            OutputOfProgram output = new OutputOfProgram();
            output.MonetarySum(AllEmployees);

        }
    }
}
