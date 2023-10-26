using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static bool IsInsideFigure(double x, double y)
        {
            // Проверка на точку в фигуре
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c;
            if (a > 0)
            {
                c = Math.Max(a, b);
            }
            else
            {
                c = Math.Min(a, b);
            }
            Console.WriteLine($"1.3: {c}");
            Console.WriteLine("\n");

            Console.WriteLine("1.2: ");
            double r = 3.2;
            double s = 3.5;
            //1
            if (2 * Math.Sqrt(r / 3.14) <= Math.Sqrt(s))
            {
                Console.WriteLine("1) Да, поместится");
            }
            else
            {
                Console.WriteLine("1) Нет, не поместится");
            }
            //2
            r = 3.2;
            s = 4;
            if (2 * Math.Sqrt(r / 3.14) <= Math.Sqrt(s))
            {
                Console.WriteLine("2) Да, поместится");
            }
            else
            {
                Console.WriteLine("2) Нет, не поместится");
            }
            //3
            r = 6;
            s = 9;
            if (2 * Math.Sqrt(r / 3.14) <= Math.Sqrt(s))
            {
                Console.WriteLine("3) Да, поместится");
            }
            else
            {
                Console.WriteLine("3) Нет, не поместится");
            }
            Console.WriteLine("\n");

            Console.WriteLine("1.9: ");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x <= -1)
            {
                Console.WriteLine("x = " + x + " y = 0");
            }
            if (x > -1 & x <= 0)
            {
                Console.WriteLine("x = " + x + " y = " + (1 + x));
            }
            if (x > 0)
            {
                Console.WriteLine("x = " + x + " y = 1");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Введите количество учеников в классе :");
            int n = int.Parse(Console.ReadLine());
            double totalMilk = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Введите вес ученика {i} (кг):");
                double weight = double.Parse(Console.ReadLine());

                if (weight < 30)
                {
                    totalMilk += 200;
                }
            }
            double totalMilkInLiters = totalMilk / 1000;
            Console.WriteLine($"2.3: Ежедневно для класса из {n} учеников потребуется {totalMilkInLiters} литров молока.");
            Console.WriteLine("\n");

            Console.WriteLine("Введите количество точек (n):");
            int k = Convert.ToInt32(Console.ReadLine());
            int pointsInsideFigure = 0;
            for (int i = 1; i <= k; i++)
            {
                Console.WriteLine($"Введите координату x для точки {i}:");
                double x1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Введите координату y для точки {i}:");
                double y1 = Convert.ToDouble(Console.ReadLine());

                if (IsInsideFigure(x1, y1))
                {
                    pointsInsideFigure++;
                }
            }
            Console.WriteLine($"2.6: {pointsInsideFigure} принадлежат фигуре.");
            Console.WriteLine("\n");

            Console.WriteLine("Введите количество спортсменов (n):");
            int t = Convert.ToInt32(Console.ReadLine());
            if (t <= 0)
            {
                Console.WriteLine("Некорректное количество спортсменов.");
                return;
            }
            double bestTime = double.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Введите результат спортсмена {i} (время в секундах):");
                double time = Convert.ToDouble(Console.ReadLine());
                if (time < bestTime)
                {
                    bestTime = time;
                }
            }
            if (bestTime != double.MaxValue)
            {
                Console.WriteLine($"Лучший результат: {bestTime} секунд.");
            }
            else
            {
                Console.WriteLine("Не введено ни одного результата.");
            }
        }
    }
}