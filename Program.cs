using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static int n;
        public static double factorial(double xo)
        {
            if (xo == 1 ^ xo == 0)
            {
                return 1;
            }
            else return xo * factorial(xo - 1);
        }

        static void Main(string[] args)
        {
            double s = 0;
            Console.WriteLine();

            for (int i = 2; i <= 35; i += 3)
            {
                s += i;
            }
            Console.WriteLine($"1.1: {s}");
            Console.WriteLine();

            s = 0;
            for (double i = 1; i <= 10; i++)
            {
                s += 1 / i;
            }
            Console.WriteLine($"1.2: {s}");
            Console.WriteLine();

            s = 0;
            for (double i = 2; i <= 112; i++)
            {
                s += i / (i + 1);
            }
            Console.WriteLine($"1.3: {s}");
            Console.WriteLine();

            s = 0;
            Console.WriteLine("Введите x: ");
            double xo = Convert.ToDouble(Console.ReadLine());
            for (double i = 1; i <= 9; i++)
            {
                s += Math.Cos(i * xo) / Math.Pow(xo, i);
            }
            Console.WriteLine($"1_4: {s}");
            Console.WriteLine();

            s = 0;
            Console.WriteLine("Введите p: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите h: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            for (double i = 0; i <= 9; i++)
            {
                s += (p + i * h) * (p + i * h);
            }
            Console.WriteLine($"1.5: {s}");
            Console.WriteLine();

            s = 0;
            double y;
            Console.WriteLine("1_6:");
            Console.WriteLine("  x   |  y");
            for (double i = -4; i <= 4; i += 0.5)
            {
                y = 0.5 * i * i - 7 * i;
                Console.WriteLine($"{i}     {y}");
            }
            Console.WriteLine();

            s = 1;
            for (double i = 1; i <= 6; i++)
            {
                s *= i;
            }
            Console.WriteLine($"1.7: {s}");
            Console.WriteLine();

            s = 0;
            double k = 1;
            for (double i = 1; i <= 6; i++)
            {
                k *= i;
                s += k;
            }
            Console.WriteLine($"1.8: {s}");
            Console.WriteLine();

            s = 0;
            k = 1;
            int z = -1;
            for (double i = 1; i <= 6; i++)
            {
                k *= i;
                s += z * Math.Pow(5, i) / k;
                z *= -1;
            }
            Console.WriteLine($"1.9: {s}");
            Console.WriteLine();

            s = 1;
            for (double i = 1; i <= 7; i++)
            {
                s *= 3;
            }
            Console.WriteLine($"1.10: {s}");
            Console.WriteLine();

            Console.WriteLine("1.11:");
            for (double i = 1; i <= 6; i++)
            {
                Console.Write($"{i} ");
            }
            Console.Write("\n");
            for (double i = 1; i <= 6; i++)
            {
                Console.Write("5 ");
            }
            Console.WriteLine("\n");

            s = 0;
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            for (double i = 0; i <= 10; i++)
            {
                s += 1 / Math.Pow(x, i);
            }
            Console.WriteLine($"1.12: {s}");
            Console.WriteLine();

            Console.WriteLine("1.13:");
            Console.WriteLine("  x   |   y");
            for (double _ = -1.5; _ <= 1.5; _ += 0.1)
            {
                if (_ <= -1)
                {
                    y = 1;
                }
                else if (_ > -1 & _ <= 1)
                {
                    y = -_;
                }
                else
                {
                    y = -1;
                }
                _ = Math.Round(_, 1);
                y = Math.Round(y, 1);
                Console.WriteLine($"{_}     {y}");
            }
            Console.WriteLine();

            Console.WriteLine("1.14:");
            double a = 1;
            double b = 1;
            double c;
            Console.Write("1 1 ");
            for (double t = 1; t <= 6; t++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write($"{b} ");
            }
            Console.WriteLine("\n");

            double a1 = 1;
            double b1 = 1;
            double a2 = 2;
            double b2 = 1;
            double a3;
            double b3;
            s = a1 / b1 + a2 / b2;
            for (double u = 1; u <= 3; u++)
            {
                a3 = a1 + a2;
                b3 = b1 + b2;
                s += a3 / b3;
                a1 = a2;
                b1 = b2;
                a2 = a3;
                b2 = b3;
            }
            Console.WriteLine($"1.15: {s}");
            Console.WriteLine("\n");

            Console.WriteLine("Введите x: ");
            double m = Math.Cos(Convert.ToDouble(Console.ReadLine()));
            double r = 1, q = 0;
            while (Math.Cos(r * x) / (r * r) >= 0.0001)
            {
                q += m;
                r++;
                m = Math.Cos(r * x) / (r * r);
            }
            Console.WriteLine($"2.1: {q}");
            Console.WriteLine();

            int L = 30000;
            int o = 1;
            int e = 1;

            while (e <= L)
            {
                o += 3;
                e *= o;
            };
            Console.WriteLine($"2.2: {o - 1}");
            Console.WriteLine();

            s = 0;
            n = 0;
            Console.WriteLine("Введите a: ");
            double a10 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите h: ");
            double h1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            while (s <= p)
            {
                s += a10 + h1 * n;
                n++;
            }
            n--;
            Console.WriteLine($"2.3: {n}");
            Console.WriteLine();

            s = 0;
            Console.WriteLine("Введите x: |x| < 1)");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double d = 1;
            while (d >= 0.0001)
            {
                s += d;
                d *= x1 * x1;
            }
            Console.WriteLine($"2.4: {s}");
            Console.WriteLine();

            Console.WriteLine("Введите n: ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите m: ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double ch = 0;
            while (l >= m)
            {
                ch++;
                l -= m;
            }
            Console.WriteLine($"2.5: Частное: {ch}, остаток: {l}");
            Console.WriteLine();

            string except = "не выполнять";
            Console.WriteLine($"2.6: {e}");
            Console.WriteLine();

            double dayly = 10;
            double day = 1;
            s = 10;
            bool f1, f2, f3;
            f1 = f2 = f3 = false;
            double g1, g2, g3;
            g1 = g2 = g3 = 1;
            while ((f1 & f2 & f3) == false)
            {
                day++;
                dayly *= 1.1;
                s += dayly;
                if (day == 7 & f1 == false)
                {
                    f1 = true;
                    g1 = s;
                }
                if (s >= 100 & f2 == false)
                {
                    f2 = true;
                    g2 = day;
                }
                if (dayly > 20 & f3 == false)
                {
                    f3 = true;
                    g3 = day;
                }
            }
            Console.WriteLine($"2.7: а) {g1} б) {g2} в){g3}");
            Console.WriteLine();

            s = 10000;
            int w = 0;
            while (s < 20000)
            {
                s *= 1.08;
                w++;
            }
            Console.WriteLine($"2.8: {w}");
            Console.WriteLine("\n");

            double A = 0.1, B = 1, H = 0.1;
            for (double X = A; X <= B; X += H)
            {
                double S = 0;
                for (double i = 0; ; i++)
                {
                    double K = Math.Pow(-1, i) * (Math.Pow(X, 2 * i) / factorial(2 * i));
                    if (Math.Abs(K) < 0.0001)
                    {
                        break;
                    }
                    S += K;
                    Console.WriteLine($"x = {X}, s = {S}, y = {Math.Cos(X)}");
                }
            }
        }
    }
}
