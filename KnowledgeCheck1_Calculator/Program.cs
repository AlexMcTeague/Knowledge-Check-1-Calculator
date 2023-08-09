using System;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            var calculator = new Calculator();
            double number1;
            double number2;

            while (true)
            {
                Console.WriteLine("Type 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division. Type \"exit\" to close the calculator.");
                input = Console.ReadLine();
                if (input == "exit") break;

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter 2 numbers to add");

                        number1 = GetNumber();
                        number2 = GetNumber();

                        Console.WriteLine($"{number1} + {number2} = {calculator.Add(number1, number2)}");
                        break;

                    case "2":
                        Console.WriteLine("Enter 2 numbers to subtract");

                        number1 = GetNumber();
                        number2 = GetNumber();

                        Console.WriteLine($"{number1} - {number2} = {calculator.Subtract(number1, number2)}");
                        break;

                    case "3":
                        Console.WriteLine("Enter 2 numbers to multiply");

                        number1 = GetNumber();
                        number2 = GetNumber();

                        Console.WriteLine($"{number1} * {number2} = {calculator.Multiply(number1, number2)}");
                        break;

                    case "4":
                        Console.WriteLine("Enter 2 numbers to divide");

                        number1 = GetNumber();
                        number2 = GetNumber();

                        Console.WriteLine($"{number1} / {number2} = {calculator.Divide(number1, number2)}");
                        break;

                    default:
                        Console.WriteLine("Unknown input");
                        break;
                }
            }
        }

        public static double GetNumber()
        {
            var number = Console.ReadLine();

            if (double.TryParse(number, out double doubNum))
                return doubNum;
            else
            {
                Console.WriteLine("Your input was not a number. Defaulting to 0");
                return 0.0;
            } 
        }
    }
}