using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            while (true)
            {
                Console.WriteLine("Choose operation:\n1 - Addition;\n2 - Subtraction; \n3 - Multiplication; \n4 - Division; \n5 - Exit programm");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        Console.WriteLine("Addition");
                        Console.WriteLine("Enter the first number");
                        double a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number");
                        double b = Convert.ToInt32(Console.ReadLine());
                        double c;
                        c = a + b;
                        Console.WriteLine($"The result is: {c}");
                        break;
                    case "2":
                        Console.WriteLine("Subtraction");
                        Console.WriteLine("Enter the first number");
                        double d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number");
                        double e = Convert.ToInt32(Console.ReadLine());
                        double f;
                        f = d - e;
                        Console.WriteLine($"The result is: {f}");
                        break;
                    case "3":
                        Console.WriteLine("Multiplication");
                        Console.WriteLine("Enter the first number");
                        double k = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number");
                        double l = Convert.ToInt32(Console.ReadLine());
                        double m;
                        m = l * k;
                        Console.WriteLine($"The result is: {m}");
                        break;
                    case "4":
                        Console.WriteLine("Division");
                        Console.WriteLine("Enter the first number");
                        double o = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number");
                        double p = Convert.ToInt32(Console.ReadLine());
                        double r;
                        r = o / p;
                        Console.WriteLine($"The result is: {r}");
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
