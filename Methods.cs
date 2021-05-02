using System;

namespace _1761
{
    class Methods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите метод:");
            Console.WriteLine("1) Половинного деления\n2) Итераций\n3) Ньютона\n");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1) { Console.WriteLine($"f(x) = 0 при x = {Half_division()}"); }
            else if (choice == 2) { Console.WriteLine($"f(x) = 0 при x = {Iteration()}"); }
            else if (choice == 3) { Console.WriteLine($"f(x) = 0 при x = {Newton()}"); }
            else { Console.WriteLine("Неверное значение. Перезапустите программу."); }
            Console.ReadKey();
        }

        // 1
        private static double Half_division()
        {
            // #30
            // [2; 3] -> 2.4200
            // y = 0.6 * 3^x - 2.3 * x - 3
            Console.WriteLine("\nМетод половинного деления:");
            Console.WriteLine("f(x) = 0.6 * 3^x - 2.3 * x - 3");

            double x = 2.5, a = 2, b = 3; // (2 + 3) / 2
            if (Func_hd(x) == 0)
            {
                return Math.Round(x, 4);
            }
            else
            {
                int counter = 0;
                do
                {
                    if (Func_hd(x) * Func_hd(a) < 0)
                    {
                        b = x;
                    }
                    else
                    {
                        a = x;
                    }
                    x = (a + b) / 2;
                    counter++;
                }
                while (Math.Abs(b - a) > 1e-4);
                Console.WriteLine($"Количество делений: {counter}");
            }
            return Math.Round(x, 4);
        }
        private static double Func_hd(double x)
        {
            // y = 0.6 * 3^x - 2.3 * x - 3
            return 0.6 * Math.Pow(3, x) - 2.3 * x - 3;
        }

        // 2
        private static double Iteration()
        {
            // #13
            // [1.2; 2] -> 1.3077 
            // y = x - 2 + Math.Sin(1 / x)
            Console.WriteLine("\nМетод итераций:");
            Console.WriteLine("f(x) = x - 2 + sin(1/x)");

            double x1 = 1.2, x2 = 2;

            // Проверка на сходимость:
            // d(phi)/dx = -cos(1/x)*(-1/x^2) = cos(1/x)/x^2
            // Достаточное условие сходимости: |d(phi)/dx| < 1
            if (Math.Abs(Math.Cos(1 / x2) / Math.Pow(x2, 2)) >= 1)
            {
                Console.WriteLine("Не удовлетворяет условию сходимости");
                return 0;
            }
            else
            {
                int iter_counter = 0;
                do
                {
                    x2 = Phi(x1);
                    x1 = x2;
                    iter_counter++;
                }
                while (Math.Abs(x1 - Phi(x1)) > 1e-5);
                Console.WriteLine($"Количество итераций: {iter_counter}");
                return Math.Round(x2, 4);
            }
        }
        private static double Phi(double x)
        {
            // y = x - 2 + Math.Sin(1 / x) = 0 => phi(x) = 2 - Math.Sin(1 / x)
            return 2 - Math.Sin(1 / x);
        }

        // 3
        private static double Newton()
        {
            // # 14
            // [3; 4] -> 3.5265
            // y = e^x + lnx - 10x
            Console.WriteLine("\nМетод Ньютона:");
            Console.WriteLine("f(x) = e^x + lnx - 10x");

            double x0 = 4, x1 = 3;
            if (Func_n(x0) * D2Func_n(x0) > 0)
            {
                int ev_counter = 0;
                do 
                {
                    // Зависимость x1 от x0 выводим из уравнения касательной
                    // f(x0)/(x0-x1) = f'(x0) => x1 = x0 - f(x0)/f'(x0)
                    x0 = x1;
                    x1 = x0 - Func_n(x0) / DFunc_n(x0);
                    ev_counter++;
                }
                while (Math.Abs(x1 - x0) > Math.Sqrt(1e-4)/10);
                Console.WriteLine($"Количество вычеслений: {ev_counter}");
                return Math.Round(x1, 4);
            }
            else
            {
                Console.WriteLine("Не удовлетворяет условию сходимости");
                return 0;
            }
        }
        private static double Func_n(double x)
        {
            return Math.Exp(x) + Math.Log(x) - 10 * x;
        }
        private static double DFunc_n(double x)
        {
            // y' = e^x + 1/x - 10
            return Math.Exp(x) + 1 / x - 10;
        }
        private static double D2Func_n(double x)
        {
            // y" = e^x - 1/x^2
            return Math.Exp(x) - 1 / (x * x);
        }
    }
}
