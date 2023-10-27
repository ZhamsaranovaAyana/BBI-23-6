//2.9.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("введите количество спортсменов: ");
        int n = int.Parse(Console.ReadLine());

        int bestResult = int.MaxValue;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"введите результат спортсмена {i}: ");
            int result = int.Parse(Console.ReadLine());

            if (result < bestResult)
            {
                bestResult = result;
            }
        }

        Console.WriteLine($"лучший результат спортсмена: {bestResult}");
    }
}