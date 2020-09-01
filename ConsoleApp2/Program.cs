using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение Калькулятор");
            while (true)
            {
                Console.WriteLine("Выберите операцию:\n1 - Сложение;\n2 - Вычитание; \n3 - Умножение; \n4 - Деление; \n5 - Выход из программы");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        Console.WriteLine("операция сложения");
                        Console.WriteLine("Введите первое число");
                        double a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        double b = Convert.ToInt32(Console.ReadLine());
                        double c;
                        c = a + b;
                        Console.WriteLine($"Результат: {c}");
                        break;
                    case "2":
                        Console.WriteLine("операция вычитания");
                        Console.WriteLine("Введите первое число");
                        double d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        double e = Convert.ToInt32(Console.ReadLine());
                        double f;
                        f = d - e;
                        Console.WriteLine($"Результат: {f}");
                        break;
                    case "3":
                        Console.WriteLine("операция умножения");
                        Console.WriteLine("Введите первое число");
                        double k = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        double l = Convert.ToInt32(Console.ReadLine());
                        double m;
                        m = l * k;
                        Console.WriteLine($"Результат: {m}");
                        break;
                    case "4":
                        Console.WriteLine("операция деления");
                        Console.WriteLine("Введите первое число");
                        double o = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        double p = Convert.ToInt32(Console.ReadLine());
                        double r;
                        r = o / p;
                        Console.WriteLine($"Результат: {r}");
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
