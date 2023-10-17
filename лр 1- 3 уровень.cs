using System;
class Program
{
    public static void Main()
    {
        double sum = 0;
        double a = 0.1;
        double b = 1;
        double h = 0.1;
        int i = 0;
        for (double x = a; x <= b; x += h, i++)
        {
            double cur;
            long fact = 1;
            double y = Math.Cos(x);
            for (int g = 2; g <= 2 * i; g++)
            {
                fact = fact * g;
            }
            if (i % 2 == 0)
            {
                cur = Math.Pow(x, 2 * i) / fact;
            }
            else
            {
                cur = -1 * Math.Pow(x, 2 * i) / fact;
            }
            if (Math.Abs(cur) < 0.0001)
            {
                break;
            }
            sum += cur;
            Console.WriteLine($"i = {i}, x = {x}, current element = {cur}, cos(x) = {y} \n\n");
        }
        Console.WriteLine($"sum = {sum}");
    }
};
