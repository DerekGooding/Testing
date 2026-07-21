# C# Console Calculator Application Instructions

## Overview
This guide will walk you through creating a C# console calculator application that can perform basic arithmetic operations (addition, subtraction, multiplication, and division). The application will handle user input, perform calculations, and display results with error handling for invalid operations.

## Prerequisites
1. [.NET SDK 8.0+](https://dotnet.microsoft.com/download/dotnet/8.0) installed
2. Code editor (e.g., Visual Studio, Visual Studio Code, or any text editor)

## Step-by-Step Instructions

### 1. Open Project Files
1. Locate the `ConsoleApp1.csproj` and `Program.cs` files in your project directory
2. Open both files in your code editor

### 2. Modify Program.cs
1. Replace the existing `Main` method with the following calculator implementation:

2. Save the changes to `Program.cs`

### 3. Build and Run the Application
1. Open a terminal/command prompt in your project directory
2. Build the application:
   ```bash
   dotnet build
   ```
3. Run the application:
   ```bash
   dotnet run
   ```

### 4. Test the Application
Try these sample inputs and verify the outputs:
- `5 + 3` → Should display `Result: 5 + 3 = 8`
- `10 - 2` → Should display `Result: 10 - 2 = 8`
- `4 * 5` → Should display `Result: 4 * 5 = 20`
- `6 / 3` → Should display `Result: 6 / 3 = 2`
- `8 / 0` → Should display division by zero error
- `invalid input` → Should display format error

### 5. Additional Improvements (Optional)
1. Add support for decimal numbers (already handled by `double.Parse`)
2. Implement a loop for continuous calculations
3. Add a menu system for multiple operations
4. Format output with currency symbols or scientific notation

## Troubleshooting
- **"The process cannot access the file" error**: Ensure no other instance of the application is running
- **"Could not load file or assembly" error**: Verify that the .NET SDK is properly installed and the project file is correctly formatted
- **"Input string was not in a correct format" error**: Check that numbers are entered correctly (no letters or symbols)

## Conclusion
You've now created a functional C# console calculator application with error handling and user input support. This foundation can be expanded with additional features like history tracking, advanced mathematical functions, or a graphical user interface (GUI) using Windows Forms or WPF.
