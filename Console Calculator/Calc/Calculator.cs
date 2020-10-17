using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator.Calc
{
    public class Calculator
    {

        public static int Add(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            int Answer = Num1 + Num2;
            return Answer;  
        }

        public static int Subtract(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            int Answer = Num1 - Num2;
            return Answer;
        }

        public static int Multiply(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            int Answer = Num1 * Num2;
            return Answer;
        }

        public static int Divide(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            int Answer = Num1 / Num2;
            return Answer;
        }

        private int GetCalcNum()
        {
            int num;

            bool parseCheck = Int32.TryParse(Console.ReadLine(), out num);

            while (!parseCheck)
            {
                Console.WriteLine("Error: Try again! Make sure you're using a number.");
                parseCheck = Int32.TryParse(Console.ReadLine(), out num);
            }

            return num;
        }

    }
}
