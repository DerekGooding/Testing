# Autonomous Agent Workflow for C# Calculator Project

## Overview
This document outlines how an autonomous agent would systematically develop, test, and maintain the C# console calculator application. The agent follows strict rules to ensure only working, testable code is implemented without placeholders or TODOs.

## Existing Project Structure
- **Files**: `ConsoleApp1.csproj` (project file), `Program.cs` (main logic)
- **Instructions**: Detailed in `instructions.md` and task files
- **Allowed Modifications**: Only `Program.cs` may be edited (project file is immutable)

## Agent Constraints
1. **No Placeholders**: All code must be fully implemented
2. **Track Progress**: Documents completed tasks in comments
3. **Test-Driven**: Implements code that passes all test cases
4. **No TODOs**: Must resolve all implementation details

## Workflow Phases
### 1. Environment Setup
- Verifies .NET SDK 8.0 installation
- Confirms project files exist and are valid
- Creates task directory structure

### 2. Core Implementation
- Modifies `Program.cs` to implement:
  - Input parsing
  - Mathematical operations
  - Error handling
  - Output formatting
- Adds comments documenting completed work

### 3. Testing
- Executes all test cases from `4-Test-Application.md`
- Verifies error handling for:
  - Invalid formats
  - Division by zero
  - Non-numeric inputs

### 4. Maintenance
- Documents solutions in `6-Troubleshooting.md`
- Updates task files with completed work
- Ensures no residual TODOs or placeholders

## Example Implementation
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Display welcome message
        Console.WriteLine("Simple Calculator v1.0");
        Console.WriteLine("Enter expression (e.g., 5 + 3): ");
        string input = Console.ReadLine();
        
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
```

## Verification
- All code paths are testable with inputs from `4-Test-Application.md`
- No TODOs or placeholders remain in the code
- Task files document completed work and next steps
- Troubleshooting solutions are documented in `6-Troubleshooting.md`

## Maintenance
The agent will:
1. Add comments to `Program.cs` documenting completed tasks
2. Update task files with progress
3. Ensure no residual TODOs or unimplemented features
4. Maintain test coverage for all scenarios