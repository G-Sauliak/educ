using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            string notice = "wrong data (use numbers)";
            while (true)
            {
                Console.WriteLine("Choose operation:\n1 - Addition;\n2 - Subtraction; \n3 - Multiplication; \n4 - Division; \n5 - Square root \n6 - Exit programm");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        Console.WriteLine("Addition");
                        double a, b, c;
                    Begin:
                        Console.WriteLine("Enter the first number");
                        bool res1 = double.TryParse(Console.ReadLine(), out a);
                        if (!res1)
                        {
                            Console.WriteLine(notice);
                            goto Begin;
                        }
                    Begin2:
                        Console.WriteLine("Enter the second number");
                        bool res2 = double.TryParse(Console.ReadLine(), out b);
                        if (!res2)
                        {
                            Console.WriteLine(notice);
                            goto Begin2;
                        }
                        c = a + b;
                        Console.WriteLine($"The result is: {c}");
                        break;
                    case "2":
                        Console.WriteLine("Subtraction");
                        double d, e, f;
                    Begin3:
                        Console.WriteLine("Enter the first number");
                        bool res3 = double.TryParse(Console.ReadLine(), out d);
                        if (!res3)
                        {
                            Console.WriteLine(notice);
                            goto Begin3;
                        }
                    Begin4:
                        Console.WriteLine("Enter the second number");
                        bool res4 = double.TryParse(Console.ReadLine(), out e);
                        if (!res4)
                        {
                            Console.WriteLine(notice);
                            goto Begin4;
                        }
                        f = d - e;
                        Console.WriteLine($"The result is: {f}");
                        break;
                    case "3":
                        Console.WriteLine("Multiplication");
                        double k, l, m;
                    Begin5:
                        Console.WriteLine("Enter the first number");
                        bool res5 = double.TryParse(Console.ReadLine(), out k);
                        if (!res5)
                        {
                            Console.WriteLine(notice);
                            goto Begin5;
                        }
                    Begin6:
                        Console.WriteLine("Enter the second number");
                        bool res6 = double.TryParse(Console.ReadLine(), out l);
                        if (!res6)
                        {
                            Console.WriteLine(notice);
                            goto Begin6;
                        }
                        m = l * k;
                        Console.WriteLine($"The result is: {m}");
                        break;
                    case "4":
                        Console.WriteLine("Division");
                        double o, p, r;
                    Begin7:
                        Console.WriteLine("Enter the first number");
                        bool res7 = double.TryParse(Console.ReadLine(), out o);
                        if (!res7)
                        {
                            Console.WriteLine(notice);
                            goto Begin7;
                        }
                    Begin8:
                        Console.WriteLine("Enter the second number");
                        bool res8 = double.TryParse(Console.ReadLine(), out p);
                        if (!res8)
                        {
                            Console.WriteLine(notice);
                            goto Begin8;
                        }
                        r = o / p;
                        Console.WriteLine($"The result is: {r}");
                        break;
                    case "5":
                        Console.WriteLine("Square root");
                    Begin9:
                        Console.WriteLine("Enter the number you want to get the square root of");
                        double q;
                        bool res9 = double.TryParse(Console.ReadLine(), out q);
                        double sqrt = Math.Sqrt(q);
                        if (!res9)
                        {
                            Console.WriteLine(notice);
                            goto Begin9;
                        }
                        else if (sqrt >= 0)
                        {
                            Console.WriteLine($"The result is: {sqrt}");
                        }
                        else
                        {
                            Console.WriteLine("You can't input negative number!");
                            goto Begin9;
                        }
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
