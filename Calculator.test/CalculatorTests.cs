using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.test
{
    [TestClass]
    public class CalculatorTests
    {
        private const string WelcomeMessage = "Simple Calculator v1.0";
        private const string FormatMessage = "Invalid format. Use: number operator number";
        private const string DivisionByZeroMessage = "Division by zero";
        private const string NonNumericMessage = "Input must be a valid numeric expression";

        [TestMethod]
        [DataRow("2 + 2", "4")]
        [DataRow("5 + 3", "8")]
        [DataRow("10 + 0", "10")]
        [DataRow("-5 + 3", "-2")]
        [DataRow("2.5 + 3.5", "6.0")]
        public void TestAddition(string input, string expected)
        {
            var output = RunCalculator(input);
            Assert.AreEqual(expected, output.Trim());
        }

        [TestMethod]
        [DataRow("5 - 3", "2")]
        [DataRow("10 - 0", "10")]
        [DataRow("-5 - 3", "-8")]
        [DataRow("2.5 - 3.5", "-1.0")]
        public void TestSubtraction(string input, string expected)
        {
            var output = RunCalculator(input);
            Assert.AreEqual(expected, output.Trim());
        }

        [TestMethod]
        [DataRow("2 * 3", "6")]
        [DataRow("10 * 0", "0")]
        [DataRow("-5 * 3", "-15")]
        [DataRow("2.5 * 3.5", "8.75")]
        public void TestMultiplication(string input, string expected)
        
        {
            var output = RunCalculator(input);
            Assert.AreEqual(expected, output.Trim());
        }

        [TestMethod]
        [DataRow("6 / 3", "2")]
        [DataRow("10 / 2", "5")]
        [DataRow("-6 / 3", "-2")]
        [DataRow("2.5 / 0.5", "5.0")]
        public void TestDivision(string input, string expected)
        {
            var output = RunCalculator(input);
            Assert.AreEqual(expected, output.Trim());
        }

        [TestMethod]
        [DataRow("6 / 0", DivisionByZeroMessage)]
        [DataRow("5 / 0", DivisionByZeroMessage)]
        public void TestDivisionByZero(string input, string expected)
        {
            var output = RunCalculator(input);
            Assert.AreEqual(expected, output.Trim());
        }

        [TestMethod]
        [DataRow("invalid input", NonNumericMessage)]
        [DataRow("5 +", NonNumericMessage)]
        [DataRow("+ 3", NonNumericMessage)]
        [DataRow("5 + 3 + 2", FormatMessage)]
        [DataRow("5 + 3a", NonNumericMessage)]
        public void TestInvalidInputs(string input, string expected)
        {
            var output = RunCalculator(input);
            Assert.AreEqual(expected, output.Trim());
        }

        private string RunCalculator(string input)
        {
            var originalOut = Console.Out;
            var sb = new System.Text.StringBuilder();
            var writer = new System.IO.StringWriter { Encoding = System.Text.Encoding.UTF8 };
            Console.SetOut(writer);
            
            try
            {
                Console.WriteLine(WelcomeMessage);
                Console.Write("Enter expression (e.g., 5 + 3): ");
                Console.SetIn(new System.IO.StringReader(input));
                Console.WriteLine();
                
                // Simulate Main() execution
                var program = new Program();
                program.Main(new string[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.SetOut(originalOut);
            }
            
            return writer.ToString();
        }
    }
}