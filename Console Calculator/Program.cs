using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_Calculator.Calc;
using Console_Calculator.GUI;

namespace Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listing all of the available operators
            string[] calcOp = new string[4] { "+", "-", "*", "/" };
            // Creating the first number variable
            int firstNumber;
            // Creating the second number variable
            int secondNumber;
            // Creating the user operator input variable
            string userOp;
            // Creating the program restart check variable
            bool restartCalc = false;
            // Creating the check for final input variable
            bool opSuccess = false;
            

            do
            {
                /* Creating the Boolean statement for when the *
                 * User has finished creating the equation.    */
                bool numSucess = false;

                // Prints start-up message
                Start.Print();
                // User input for the operator
                userOp = Console.ReadLine();

                // Checking if User Input is a valid operator
                if (userOp == calcOp[0] || userOp == calcOp[1] || userOp == calcOp[2] || userOp == calcOp[3])
                {   // Looping to check which operator was selected
                    for (int i = 0; i <= 3; i++)
                    {
                        // Operator check
                        if (userOp == calcOp[i])
                        {
                            // When the User inputted operator has been found                            
                            Operator.Print(calcOp[i]);

                            // Allows User to move onto inputting the numbers for the equation 
                            opSuccess = true;                            
                        }
                    }
                }
                else
                {
                    /* Executed if the User doesn't provide a valid operator.   *
                     * The "opSuccess" value will stay false, so it will now    *
                     * ignore the rest of the calculation code, and move to the *
                     * end of the loop, where the user will get asked if they   *
                     * want to restart or not.                                  */
                    Error.Operator();
                }

                // Checking if the User inputted a valid operator
                if (opSuccess == true)
                {
                    // Checking if the Operator selected was [+]
                    if (userOp == calcOp[0])
                    {
                        /* Loops through getting the first number, second  *
                         * number and the answer. The reason why it's been *
                         * put in a loop is so that a restart function can *
                         * be added at a later time if needed/requested.   */
                        while (numSucess == false)
                        {
                            try
                            {
                                // First Number Request     
                                FirstNum.Message();
                                firstNumber = Convert.ToInt32(Console.ReadLine());
                                FirstNum.Print(userOp, firstNumber);

                                // Second Number Request
                                SecondNum.Message();
                                secondNumber = Convert.ToInt32(Console.ReadLine());
                                SecondNum.Print(userOp, secondNumber);

                                // The User has finished the equation
                                numSucess = true;

                                // Calculates and prints the answer
                                int result = Calculator.Add(firstNumber, secondNumber);
                                Result.Answer(userOp, firstNumber, secondNumber, result);
                            }
                            catch
                            {
                                /* Message sent when user provides *
                                 * something other than a number.  */
                                Error.InvalidNumber();
                                // The User has finished the equation
                                numSucess = true;
                            }
                        }
                    }
                    // Checking if the Operator selected was [-]
                    if (userOp == calcOp[1])
                    {
                        while (numSucess == false)
                        {
                            try
                            {
                                // First Number Request     
                                FirstNum.Message();
                                firstNumber = Convert.ToInt32(Console.ReadLine());
                                FirstNum.Print(userOp, firstNumber);

                                // Second Number Request
                                SecondNum.Message();
                                secondNumber = Convert.ToInt32(Console.ReadLine());
                                SecondNum.Print(userOp, secondNumber);

                                // The User has finished the equation
                                numSucess = true;

                                // Calculates and prints the answer
                                int result = Calculator.Subtract(firstNumber, secondNumber);
                                Result.Answer(userOp, firstNumber, secondNumber, result);
                            }
                            catch
                            {
                                /* Message sent when user provides *
                                 * something other than a number.  */
                                Error.InvalidNumber();
                                // The User has finished the equation
                                numSucess = true;
                            }
                        }
                    }
                    // Checking if the Operator selected was [*]
                    if (userOp == calcOp[2])
                    {
                        while (numSucess == false)
                        {
                            try
                            {
                                // First Number Request     
                                FirstNum.Message();
                                firstNumber = Convert.ToInt32(Console.ReadLine());
                                FirstNum.Print(userOp, firstNumber);

                                // Second Number Request
                                SecondNum.Message();
                                secondNumber = Convert.ToInt32(Console.ReadLine());
                                SecondNum.Print(userOp, secondNumber);

                                // The User has finished the equation
                                numSucess = true;

                                // Calculates and prints the answer
                                int result = Calculator.Multiply(firstNumber, secondNumber);
                                Result.Answer(userOp, firstNumber, secondNumber, result);
                            }
                            catch
                            {
                                /* Message sent when user provides *
                                 * something other than a number.  */
                                Error.InvalidNumber();
                                // The User has finished the equation
                                numSucess = true;
                            }
                        }
                    }
                    // Checking if the Operator selected was [/]
                    if (userOp == calcOp[3])
                    {
                        while (numSucess == false)
                        {
                            try
                            {
                                // First Number Request     
                                FirstNum.Message();
                                firstNumber = Convert.ToInt32(Console.ReadLine());
                                FirstNum.Print(userOp, firstNumber);

                                // Second Number Request
                                SecondNum.Message();
                                secondNumber = Convert.ToInt32(Console.ReadLine());
                                SecondNum.Print(userOp, secondNumber);

                                // The User has finished the equation
                                numSucess = true;

                                // Calculates and prints the answer
                                int result = Calculator.Divide(firstNumber, secondNumber);
                                Result.Answer(userOp, firstNumber, secondNumber, result);
                            }
                            catch
                            {
                                /* Message sent when user provides *
                                 * something other than a number.  */
                                Error.InvalidNumber();
                                // The User has finished the equation
                                numSucess = true;
                            }
                        }
                    }

                }
                // The program restart message
                Restart.Message();
                string userRestart = Console.ReadLine();
                // Checking if user requested to restart
                if (userRestart.ToLower() == "yes" || userRestart.ToLower() == "y")
                {
                    // If they do want to restart
                    restartCalc = true;
                    Console.Clear();
                    Console.Beep();
                }
                else
                {
                    // If they do not want to restart
                    restartCalc = false;
                }
            } // Checks if user wants to restart the program
            while (restartCalc == true);
            // Closes program if user does not want to continue
            System.Environment.Exit(0);
        }
    }
}