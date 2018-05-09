using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while(displayMenu)
            {
                displayMenu = Menu();
            }
        }

        private static bool Menu()
        {
            Console.Clear();
            double num1 = 0;
            Console.WriteLine("What is your first number?");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Please enter a valid number!");
                Console.WriteLine("What is your first number?");
            }

            bool operation = true;
            while (operation)
            {
                operation = Operation(num1);
            }

            Console.WriteLine("Do you want to exit?");
            string result = Console.ReadLine().Trim().ToLower();
            if (result == "y" || result == "yes")
            {
                return false;
            }
            else
                return true;
        }
 
        private static bool Operation(double num1)
        {
            Console.WriteLine("Do you want to add (+), subtract (-), multiply (*), or divide (/)?");
                string operand = Console.ReadLine().Trim().ToLower();
                if (operand == "add" || operand == "+" || operand == "addition")
                {
                    double answer = Add(num1);
                    Console.WriteLine("The answer is: " + answer);
                    return false;
                }
                else if (operand == "subtract" || operand == "-" || operand == "subtraction")
                {
                    double answer = Subtract(num1);
                    Console.WriteLine("The answer is: " + answer);
                    return false;
                }
                else if (operand == "multiply" || operand == "*" || operand == "multiplication")
                {
                    double answer = Multiply(num1);
                    Console.WriteLine("The answer is: " + answer);
                    return false;
                }
                else if (operand == "divide" || operand == "/" || operand == "division")
                {
                    double answer = Divide(num1);
                    Console.WriteLine("The answer is: " + answer);
                    return false;
                }
                else
                {
                    Console.WriteLine("Please write a proper operation!");
                    return false;
                }
        }

        private static double Add(double num1)
        {
            double num2 = 0;
            Console.WriteLine("What is your second number?");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Please enter a valid number!");
                Console.WriteLine("What is your second number?");
            }
            double answer = num1 + num2;
            return answer;
        }

        private static double Subtract(double num1)
        {
            double num2 = 0;
            Console.WriteLine("What is your second number?");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Please enter a valid number!");
                Console.WriteLine("What is your second number?");
            }
            double answer = num1 - num2;
            return answer;
        }

        private static double Multiply(double num1)
        {
            double num2 = 0;
            Console.WriteLine("What is your second number?");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Please enter a valid number!");
                Console.WriteLine("What is your second number?");
            }
            double answer = num1 * num2;
            return answer;
        }

        private static double Divide(double num1)
        {
            double num2 = 0;
            Console.WriteLine("What is your second number?");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Please enter a valid number!");
                Console.WriteLine("What is your second number?");
            }
            double answer = num1 / num2;
            return answer;
        }
    }
}
