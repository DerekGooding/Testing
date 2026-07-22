# 4. Test Application

## Objective
Verify calculator functionality with sample inputs and error scenarios

## Test Cases
1. **Valid Calculations**:
   - Input: `5 + 3`
     - Expected: `Result: 5 + 3 = 8`
   - Input: `10 - 2`
     - Expected: `Result: 10 - 2 = 8`
   - Input: `4 * 5`
     - Expected: `Result: 4 * 5 = 20`
   - Input: `6 / 3`
     - Expected: `Result: 6 / 3 = 2`

2. **Error Scenarios**:
   - Input: `8 / 0`
     - Expected: `Error: Division by zero`
   - Input: `invalid input`
     - Expected: `Error: Input string was not in a correct format`
   - Input: `5 + 3 * 2`
     - Expected: `Error: Invalid format. Use: number operator number`

## Tips
- Run tests sequentially to isolate issues
- Verify output matches expected formatting
- Check for proper error message displays