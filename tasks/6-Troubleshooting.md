# 6. Troubleshooting

## Common Issues

### 1. File Access Errors
- **Error**: "The process cannot access the file..."
- **Cause**: Another instance of the app is running
- **Solution**: Close all instances of Visual Studio/VS Code and retry

### 2. Assembly Load Errors
- **Error**: "Could not load file or assembly..."
- **Cause**: Invalid project file or missing SDK
- **Solution**: 
  1. Verify `ConsoleApp1.csproj` is valid
  2. Run `dotnet --version` to confirm SDK installation
  3. Reinstall .NET SDK 8.0 from https://dotnet.microsoft.com/download/dotnet/8.0

### 3. Format Exceptions
- **Error**: "Input string was not in a correct format"
- **Cause**: Non-numeric input detected
- **Solution**: 
  1. Ensure inputs are valid numbers
  2. Check for accidental symbols/letters in input
  3. Add input validation before parsing

### 4. Division by Zero
- **Error**: "Division by zero"
- **Cause**: User entered `x / 0`
- **Solution**: 
  1. Handle division by zero with `if (num2 == 0)` check
  2. Display clear error message to user

## Tips
- Always test with sample inputs before full deployment
- Use `try-catch` blocks for all critical operations
- Keep project files organized in dedicated folders