using System;

namespace _1761_integrals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите метод:");
            Console.WriteLine("1) Трапеций\n2) Симпсона\n");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1) { Trapezoid(); }
            else if (choice == 2) { Simpson(); }
            else { Console.WriteLine("Неверное значение. Перезапустите программу."); }
            Console.ReadKey();
        }

        // 1
        private static void Trapezoid()
        {
            // #10
            // [0; sqrt(3)]
            // n = 48
            // f(x) = x*arctgx
            // F(x) = 0.5*x^2*arctgx - 0.5*x + 0.5*arctgx
            Console.WriteLine("\nМетод трапеций:");
            Console.WriteLine("f(x) = x*arctgx");

            const double a = 0, n = 48;
            double b = Math.Sqrt(3);
            double h = (b - a) / n;
            // I ~= 0.5*h(y0 + yn + 2*sum(yi)) -> i from 1 to n-1
            double y0 = Function(a), yn = Function(b), sum = 0;
            double xi = a;
            for (int i = 1; i < n; i++)
            {
                xi = xi + h;
                sum = sum + Function(xi);
            }
            // По формуле Ньютона-Лейбница
            double integral = Math.Round(Bigfunction(b) - Bigfunction(a), 5);
            double s = Math.Round(0.5 * h * (y0 + yn + 2 * sum), 5);
            double abs = Math.Round(s - integral, 5);
            double otn = Math.Round(Math.Abs(abs) / integral, 4) * 100;
            Console.WriteLine($"F(b) - F(a) = {integral}"); // действительное значение
            Console.WriteLine($"I ~= {s}"); // эксперементальное значение
            Console.WriteLine($"Абсолютная погрешность ~= {abs}");
            Console.WriteLine($"Относительная точность приближенного значения интеграла ~= {otn}%");
        }
        // функция
        private static double Function(double x)
        {
            return x * Math.Atan(x);
        }
        // первообразная
        private static double Bigfunction(double x)
        {
            return 0.5 * x * x * Math.Atan(x) - 0.5 * x + 0.5 * Math.Atan(x);
        }

        // 2
        private static void Simpson()
        {
            // #15
            // [0; 1]
            // n = 240
            // f(x) = 2^(3*x)
            // F(x) = (2^(3*x) - 1) / 3ln2
            Console.WriteLine("\nМетод Симпсона:");
            Console.WriteLine("f(x) = 2^(3*x)");

            const double a = 0, b = 1, n = 240;
            double h = (b - a) / (2 * n);
            // I ~= (h/3)*(y0 + y2n + sum((3+ci)*yi)) -> i from 1 to 2n-1
            // ci = (-1)^(i+1)
            double y0 = Function_s(a), y2n = Function_s(b), sum = 0;
            double xi = a;
            for (int i = 1; i < 2 * n; i++)
            {
                xi = xi + h;
                sum = sum + (3 + Math.Pow(-1, i + 1)) * Function_s(xi);
            }
            // По формуле Ньютона-Лейбница
            double integral = Math.Round(Bigfunction_s(b) - Bigfunction_s(a), 4);
            double s = Math.Round((h / 3) * (y0 + y2n + sum), 4);
            double abs = Math.Round(s - integral, 4);
            double otn = Math.Round(Math.Abs(abs) / integral, 4) * 100;
            Console.WriteLine($"F(b) - F(a) = {integral}"); // действительное значение
            Console.WriteLine($"I ~= {s}"); // эксперементальное значение
            Console.WriteLine($"Абсолютная погрешность ~= {abs}");
            Console.WriteLine($"Относительная точность приближенного значения интеграла ~= {otn}%");
        }
        // функция
        private static double Function_s(double x)
        {
            return Math.Pow(2, 3 * x);
        }
        // первообразная
        private static double Bigfunction_s(double x)
        {
            return (Math.Pow(2, 3 * x) - 1) / (3 * Math.Log(2));
        }
    }
}
