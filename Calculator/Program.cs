using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Display welcome message
            Console.WriteLine("Simple Calculator v1.0");
            Console.WriteLine("Enter expression (e.g., 5 + 3): ");
            string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Error: Empty input");
            return;
        }
            
            try
            {
                // 2. Parse input into components
                string[] parts = input.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 3)
                {
                    throw new FormatException("Invalid format. Use: number operator number");
                }
                
                double num1 = double.Parse(parts[0]);
                double num2 = double.Parse(parts[2]);
                char operatorChar = parts[1][0];
                
                // 3. Perform calculation
                double result = 0;
                string operation = "";
                
                switch (operatorChar)
                {
                    case '+':
                        result = num1 + num2;
                        operation = "+";
                        break;
                    case '-':
                        result = num1 - num2;
                        operation = "-";
                        break;
                    case '*':
                        result = num1 * num2;
                        operation = "*";
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException("Division by zero");
                        }
                        result = num1 / num2;
                        operation = "/";
                        break;
                    default:
                        throw new FormatException("Invalid operator. Use +, -, *, or /");
                }
                
                // 4. Display result
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            }
            catch (Exception ex)
            {
                // 5. Handle errors
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
