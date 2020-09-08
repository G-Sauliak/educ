using System;
using System.Numerics;
using System.Threading;

namespace ConsoleApp2
{
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
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            while (true)
            {
                Console.WriteLine("Choose operation:\n1 - Addition;\n2 - Subtraction; \n3 - Multiplication; \n4 - Division; \n5 - Square root \n6 - Exit programm");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        Console.WriteLine("Addition");
                        Console.WriteLine("Enter the first number");
                        double a = ReadNumber();
                        Console.WriteLine("Enter the second number");
                        double b = ReadNumber();
                        double c = a + b;
                        Console.WriteLine($"The result is: {c}");
                        break;
                    case "2":
                        Console.WriteLine("Substraction");
                        Console.WriteLine("Enter the first number");
                        double d = ReadNumber();
                        Console.WriteLine("Enter the second number");
                        double e = ReadNumber();
                        double f = d - e;
                        Console.WriteLine($"The result is: {f}");
                        break;
                    case "3":
                        Console.WriteLine("Multiplication");
                        Console.WriteLine("Enter the first number");
                        double k = ReadNumber();
                        Console.WriteLine("Enter the second number");
                        double l = ReadNumber();
                        double m = k * l;
                        Console.WriteLine($"The result is: {m}");
                        break;
                    case "4":
                        Console.WriteLine("Division");
                        Console.WriteLine("Enter the first number");
                        double o = ReadNumber();
                        Console.WriteLine("Enter the second number");
                        double p = ReadNumber();
                        double r = o / p;
                        Console.WriteLine($"The result is: {r}");
                        break;
                    case "5":
                        Console.WriteLine("Square root");
                        Console.WriteLine("Enter the number you want to get the square root of");
                        double q = ReadNumber(true);
                        double sqrt = Math.Sqrt(q);
                        Console.WriteLine($"The result is: {sqrt}");
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
