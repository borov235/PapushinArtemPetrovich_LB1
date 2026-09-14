using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Services
{
    public class CalculatorService
    {
        public double Calculate(double first, double second, string op)
        {
            switch (op)
            {
                case "+":
                    return first + second;
                case "-":
                    return first - second;
                case "*":
                    return first * second;
                case "/":
                    return second != 0 ? first / second : 0;
                default:
                    return second;
            }
        }
    }
}
