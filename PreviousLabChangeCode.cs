using System;

class Calculator
{
    static void Main(string[] args)
    {
        bool continueCalculation = true;

        while (continueCalculation)
        {
            try
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Select an operation: +, -, *, /");
                string operation = Console.ReadLine();

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected.");
                        continue;
                }

                Console.WriteLine("The result is: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.WriteLine("Do you want to perform another calculation? (yes/no)");
            string response = Console.ReadLine().ToLower();
            continueCalculation = (response == "yes");
        }
    }
}

