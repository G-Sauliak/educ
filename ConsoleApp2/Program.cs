using System;
using System.Numerics;
using System.Threading;

namespace ConsoleApp2
{
    enum Calculation
    {
        addition = 1,
        subtraction,
        multiplication,
        division,
        sqrt
    }
    class Program
    {
        /// <summary>
        /// Chek correct symbol entering
        /// </summary>
        /// <returns></returns>
        static double ReadNumber(bool onlyPositive = false)
        {
            do
            {
                var isParsed = double.TryParse(Console.ReadLine(), out var a);
                if (!isParsed)
                {
                    Console.WriteLine("try again (enter number)");
                    continue;
                }
                if (onlyPositive && a < 0)
                {
                    Console.WriteLine("try again (enter positive number)");
                    continue;
                }
                return a;
            }
            while (true);
        }
        static double InputFirst()
        {
            Console.WriteLine("Enter the first number");
            double a = ReadNumber();
            return a;
        }
        static double InputSecond()
        {
            Console.WriteLine("Enter the second number");
            double b = ReadNumber();
            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            while (true)
            {
            Begin:
                Console.WriteLine("Choose operation:\n1 - Addition;\n2 - Subtraction; \n3 - Multiplication; \n4 - Division; \n5 - Square root \n6 - Exit programm");
                string operation = Console.ReadLine();
                if (operation == "6")
                {
                    Environment.Exit(0);
                }
                else if (operation == "5")
                {
                    Console.WriteLine("Square root");
                    Console.WriteLine("Enter the number you want to get the square root of");
                    double q = ReadNumber(true);
                    double sqrt = Math.Sqrt(q);
                    Console.WriteLine($"The result is: {sqrt}");
                    goto Begin;
                }
                double a = InputFirst();
                double b = InputSecond();
                double c;
                switch (operation)
                {
                    case "1":
                        Console.WriteLine("Addition");
                        c = a + b;
                        Console.WriteLine($"The result is: {c}");
                        break;
                    case "2":
                        Console.WriteLine("Substraction");
                        c = a - b;
                        Console.WriteLine($"The result is: {c}");
                        break;
                    case "3":
                        Console.WriteLine("Multiplication");
                        c = a * b;
                        Console.WriteLine($"The result is: {c}");
                        break;
                    case "4":
                        Console.WriteLine("Division");
                        c = a / b;
                        Console.WriteLine($"The result is: {c}");
                        break;
                    case "5":
                        Console.WriteLine("Square root");
                        Console.WriteLine("Enter the number you want to get the square root of");
                        double q = ReadNumber(true);
                        double sqrt = Math.Sqrt(q);
                        Console.WriteLine($"The result is: {sqrt}");
                        break;
                }
            }
        }
    }
}
