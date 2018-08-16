using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Calculadora
    {
        public static double work(double num1, double num2, string operador)
        {
            double finalValue;
            switch(operador)
            {
                case "+":
                    finalValue = num1 + num2;
                    break;
                case "-":
                    finalValue = num1 - num2;
                    break;
                case "*":
                    finalValue = num1 * num2;
                    break;
                case "/":
                    finalValue = num1 / num2;
                    break;
                default:
                    finalValue = 0;
                    break;
            }
            return finalValue;
        }

        public static bool validateOperator(string operador)
        {
            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
