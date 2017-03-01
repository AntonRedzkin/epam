using System;
using System.Data;

namespace DEV_2
{
    class Expression
    {
        private const String ERROR_MESSAGE =
            "Error: Incorrent symbols! Use numbers and +-*/()" + "\n" +
            "For example 283.5 / 76 + (.647 - 2.19e3) * 5 .";
        private string expression = "";

        // Input math expression from console.
        internal void inputExpression()
        {
            Console.WriteLine("Enter expression: ");
            expression = Console.ReadLine();
        }

        internal string checkExpression()
        {
            // Check expression for correct symbols.
            foreach (char c in expression)
            {
                if (!Char.IsDigit(c) && c != '+' && c != '-' && c != '*' && c != '/' &&
                    c != '(' && c != ')' && c != '.' && c != ' ' && c != 'e' && c != 'E')
                {
                    expression = " ";
                    Console.WriteLine(ERROR_MESSAGE);
                    break;
                }
            }
            // Check for correct first symbol.
            if ((expression[0] == '*') || (expression[0] == '/'))
            {
                expression = " ";
                Console.WriteLine(ERROR_MESSAGE);
            }

            // Check for correct last symbol.
            if (('.' == expression[expression.Length - 1]) || ('*' == expression[expression.Length - 1]) ||
                ('/' == expression[expression.Length - 1]) || ('-' == expression[expression.Length - 1]) ||
                ('+' == expression[expression.Length - 1]))
            {
                expression = " ";
                Console.WriteLine(ERROR_MESSAGE);
            }
            return expression;
        }

        // Calculate math expression.
        // and print a result to the console.
        internal void calculateExpression(string expression)
        {
            DataTable datatable = new DataTable();
            var result = datatable.Compute(expression, "");
            Console.WriteLine(result);
        }
    }
}
