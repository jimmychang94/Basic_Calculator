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
            // This while loop makes sure that the user input is a number.
            // What happens is that it tries to parse the user input into a double and if it works sets it to num1.
            // If it doesn't work, then the while loop is true and it goes through the while loop again and will re-read the user input.
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Please enter a valid number!");
                Console.WriteLine("What is your first number?");
            }

            double answer = Operation(num1);

            // This while loop is used in the case where someone would want to use the previous answer for another calculation
            bool keepCalculating = true;
            while (keepCalculating)
            {
                Console.WriteLine("Write \"y\" or \"yes\" if you want to use this answer in another calculation.");
                // Trim() and ToLower() are used in order to make the string uniform and easier to compare.
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
            // The while loop makes sure that the user gave a proper response.
            while (check)
            {
                Console.WriteLine("Do you want to add (+), subtract (-), multiply (*), or divide (/)?");
                string userOperation = Console.ReadLine().Trim().ToLower();
                // This switch statement checks to see what the user wrote and if it is one of the below then it would run the method below.
                // Otherwise, it would run the default which would keep it within the while loop.
                switch (userOperation)
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
                        check = false;
                        answer = AddSubtractMultiplyDivide(userOperation, num1);
                        break;
                    default:
                        Console.WriteLine("Please write a valid operation.");
                        break;
                }

            }
            return answer;

        }

        private static double AddSubtractMultiplyDivide(string userOperation, double num1)
        {
            double num2 = 0;
            Console.WriteLine("What is your second number?");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Please enter a valid number!");
                Console.WriteLine("What is your second number?");
            }
            double answer = 0;
            // This if/else statement checks to see if the user wants to add, subtract, multiply, or divide and based off of that, apply the correct operation to the two numbers and find the answer
            if (userOperation == "add" || userOperation == "+" || userOperation == "addition")
                answer = num1 + num2;
            else if (userOperation == "subtract" || userOperation == "-" || userOperation == "subtraction")
                answer = num1 - num2;
            else if (userOperation == "multiply" || userOperation == "*" || userOperation == "multiplication")
                answer = num1 * num2;
            else if (userOperation == "divide" || userOperation == "/" || userOperation == "division")
                answer = num1 / num2;

            Console.WriteLine("The answer is: " + answer);
            // Here we return the answer so that it might be used in a later operation.
            return answer;
        }

    }
}
