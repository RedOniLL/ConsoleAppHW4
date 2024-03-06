using System;

namespace ConsoleApp4
{
    public static class Class1
    {
        public static void Task1()
        {

            static string ConvertDecimalToBinary(int decimalNumber)
            {
                return Convert.ToString(decimalNumber, 2);
            }

            static int ConvertBinaryToDecimal(string binaryNumber)
            {
                return Convert.ToInt32(binaryNumber, 2);
            }


            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Decimal to Binary");
            Console.WriteLine("2. Binary to Decimal");
            Console.WriteLine("3. Exit");
            try
            {
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter a number in decimal system: ");
                        int decimalNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Result: {ConvertDecimalToBinary(decimalNumber)}");
                        break;
                    case 2:
                        Console.Write("Enter a number in binary system: ");
                        string binaryNumber = Console.ReadLine();
                        Console.WriteLine($"Result: {ConvertBinaryToDecimal(binaryNumber)}");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            catch(OverflowException) { Console.WriteLine("error"); }
        }

        public static void Task2 () {
            Console.Write("Enter a word representing a digit (zero to nine): ");
            string word = Console.ReadLine().ToLower();

            int number;
            switch (word)
            {
                case "zero":
                    number = 0;
                    break;
                case "one":
                    number = 1;
                    break;
                case "two":
                    number = 2;
                    break;
                case "three":
                    number = 3;
                    break;
                case "four":
                    number = 4;
                    break;
                case "five":
                    number = 5;
                    break;
                case "six":
                    number = 6;
                    break;
                case "seven":
                    number = 7;
                    break;
                case "eight":
                    number = 8;
                    break;
                case "nine":
                    number = 9;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a word representing a digit from zero to nine.");
                    return;
            }

            Console.WriteLine($"The digit represented by the word '{word}' is: {number}");
        }

        public static void Task4()
        {
            try
            {
                Console.Write("Enter a logical expression: ");
                string expression = Console.ReadLine();

                Console.WriteLine($"Result: {CalculateExpression(expression)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: incorrect expression format.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static bool CalculateExpression(string expression)
        {
            string[] parts = expression.Split(' ');
            if (parts.Length != 3)
            {
                throw new ArgumentException("Incorrect expression format.");
            }

            string op = parts[1];
            if (op != "<" && op != ">" && op != "<=" && op != ">=" && op != "==" && op != "!=")
            {
                throw new ArgumentException("Unknown operator.");
            }

            if (!int.TryParse(parts[0], out int operand1) || !int.TryParse(parts[2], out int operand2))
            {
                throw new FormatException();
            }

            switch (op)
            {
                case "<":
                    return operand1 < operand2;
                case ">":
                    return operand1 > operand2;
                case "<=":
                    return operand1 <= operand2;
                case ">=":
                    return operand1 >= operand2;
                case "==":
                    return operand1 == operand2;
                case "!=":
                    return operand1 != operand2;
                default:
                    throw new ArgumentException("Unknown operator.");
            }
        }
    }
}



   
  