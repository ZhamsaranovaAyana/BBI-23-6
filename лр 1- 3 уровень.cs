using System;

class Program
{
    static void Main(string[] args)
    {
        double a = 0.1, b = 1, h = 0.1;
        for (double x = a; x <= b; x += h)
        {
            double s = 0;
            for (int i = 0; ; i++)
            {
                double k = Math.Pow(-1, i) * (Math.Pow(x, 2 * i) / fac(2 * i));
                if (Math.Abs(k) < 0.0001)
                {
                    break;
                }
                s += k;
            }
            Console.WriteLine("x = {0}, s = {1}, y = {2}", x, s, y(x));
        }
    }

    static double y(double x)
    {
        return Math.Cos(x);
    }

    static double fac(int n)
    {
        double result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
