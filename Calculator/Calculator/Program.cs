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

            double answer = Operation(num1);

            bool keepCalculating = true;
            while (keepCalculating)
            {
                Console.WriteLine("Write \"y\" or \"yes\" if you want to use this answer in another calculation.");
                string reply = Console.ReadLine().Trim().ToLower();
                if (reply == "y" || reply == "yes")
                    answer = Operation(answer);
                else
                    keepCalculating = false;
            }

            Console.WriteLine("Write \"yes\" or \"y\" to exit");
            string exit = Console.ReadLine().Trim().ToLower();
            if (exit == "y" || exit == "yes")
                return false;
            else
                return true;
        }
 
        private static double Operation(double num1)
        {
            double answer = 0;
            bool check = true;
            while (check)
            {
                check = false;
                Console.WriteLine("Do you want to add (+), subtract (-), multiply (*), or divide (/)?");
                string operand = Console.ReadLine().Trim().ToLower();
                switch (operand)
                {
                    case "add":
                    case "addition":
                    case "+":
                    case "subtract":
                    case "subtraction":
                    case "-":
                    case "multiply":
                    case "multiplication":
                    case "*":
                    case "divide":
                    case "division":
                    case "/":
                        answer = AddSubtractMultiplyDivide(operand, num1);
                        break;
                    default:
                        Console.WriteLine("Please write a valid operation.");
                        check = true;
                        break;
                }

            }
            return answer;

        }

        private static double AddSubtractMultiplyDivide(string operand, double num1)
        {
            double num2 = 0;
            Console.WriteLine("What is your second number?");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Please enter a valid number!");
                Console.WriteLine("What is your second number?");
            }
            double answer = 0;
            if (operand == "add" || operand == "+" || operand == "addition")
                answer = num1 + num2;
            else if (operand == "subtract" || operand == "-" || operand == "subtraction")
                answer = num1 - num2;
            else if (operand == "multiply" || operand == "*" || operand == "multiplication")
                answer = num1 * num2;
            else if (operand == "divide" || operand == "/" || operand == "division")
                answer = num1 / num2;

            Console.WriteLine("The answer is: " + answer);
            return answer;
        }

    }
}
