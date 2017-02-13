using System;

namespace DEV_2
{
    class Program
    {
        // This program calcualate math expession
        // which supported operations : "+", "-", "*", "/" and
        // support brackets.

        static void Main(string[] args)
        {
            char again = 'y';
            while (again == 'y' || again == 'Y')
            {
                Expression expr = new Expression();
                expr.inputExpression();
                expr.calculateExpression(expr.checkExpression());
                Console.WriteLine("Do you want to continue? (y/n)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
