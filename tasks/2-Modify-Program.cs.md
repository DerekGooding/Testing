# 2. Modify Program.cs

## Objective
Implement the calculator functionality in the main program file

## Steps
1. Open `Program.cs` in your code editor
2. Replace the existing `Main` method with this calculator implementation:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator v1.0");
        Console.WriteLine("Enter expression (e.g., 5 + 3): ");
        string input = Console.ReadLine();
        
        try
        {
            // Split input into operands and operator
            string[] parts = input.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 3)
            {
                throw new FormatException("Invalid format. Use: number operator number");
            }
            
            double num1 = double.Parse(parts[0]);
            double num2 = double.Parse(parts[2]);
            char operatorChar = parts[1][0];
            
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
            
            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
```
3. Save the changes to `Program.cs`

## Tips
- Verify code formatting and syntax
- Test with sample inputs like `5 + 3`
- Ensure proper C# namespace structure