using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator.GUI

{
    class Start
    {

        public static void Print()
        {
            // Program Banner
            Console.WriteLine("#####################################");
            Console.Write("#");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("The Simply Useless Calculator V1.01");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("#");
            Console.WriteLine("#####################################");
            Console.WriteLine("-------------------------------------");
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("        Avaliable Operators        ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-");
            Console.WriteLine("-------------------------------------");

            // Addition Banner
            Console.Write("> ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[+]                    (Addition)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" <");

            // Subtraction Banner
            Console.Write("> ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[-]                 (Subtraction)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" <");

            // Multiplication Banner
            Console.Write("> ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[*]              (Multiplication)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" <");

            // Division Banner
            Console.Write("> ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[/]                    (Division)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" <");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            // Operation Enter Prompt
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[!] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter An Operation :  ");
        }

    }

    class Operator

    {

        public static void Print(string Operator)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[" + Operator + "] Operator Has Been Selected ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.Beep();
        }

    }

    class FirstNum
    {

        public static void Message()
        {
            // First Number Request
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[!] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter First Number : ");
        }

        public static void Print(string userOp, int firstNumber)
        {
            // Print First Number
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[" + userOp + "] First Number : " + firstNumber);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.Beep();
        }

    }

    class SecondNum
    {

        public static void Message()
        {
            // Second Number Request
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[!] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Second Number : ");
        }

        public static void Print(string userOp, int secondNumber)
        {
            // Print Second Number
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[" + userOp + "] Second Number : " + secondNumber);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine();
            Console.Beep();
        }
    }


    
    class Result
    {

        public static void Answer(string userOp, int firstNumber, int secondNumber, int result)
        {
            // Prints final Answer
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("[>] Answer : " + firstNumber + " " + userOp + " " + secondNumber + " = " + result + " ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.Beep();
        }


    }

    class Restart
    {

        public static void Message()
        {
            // Print Restart
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[!] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Would You Like To Restart? | (Y)es or (N)o : ");
        }

    }

    class Error
    {

        public static void Operator()
        {
            // Operator Input Error
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("ERROR MESSAGE");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("[?]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Operator Was Not Provided.");
            Console.WriteLine();
            Console.Beep();
        }

        public static void InvalidNumber()
        {
            // Number Input Error
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("ERROR MESSAGE");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("[?]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Number Wasn't Provided.");
            Console.WriteLine();
            Console.Beep();
        }
    }

}
