using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    internal class ArithmeticExpression
    {
        public ArithmeticExpression() { Console.WriteLine("enter expression (10/2+2)");
            string s = Console.ReadLine(); Expression(s);
        }
        public static double Expression(string expression)
        {
            string[] operators = { "/", "*", "+", "-" };
            string[] operands = expression.Split(operators, StringSplitOptions.RemoveEmptyEntries);

            if (operands.Length < 2)
            {
                throw new ArgumentException("Invalid expression");
            }

            double result = double.Parse(operands[0]);

            for (int i = 1; i < operands.Length; i++)
            {
                char currentOperator = expression[expression.IndexOf(operands[i]) - 1];
                double currentOperand = double.Parse(operands[i]);

                switch (currentOperator)
                {
                    case '/':
                        result /= currentOperand;
                        break;
                    case '*':
                        result *= currentOperand;
                        break;
                    case '+':
                        result += currentOperand;
                        break;
                    case '-':
                        result -= currentOperand;
                        break;
                    default:
                        throw new ArgumentException("Invalid operator");
                }
            }

            return result;
        }
    }
}
