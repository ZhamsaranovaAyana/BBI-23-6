using System;

public class lvl1n3
{
    public static void Main(string[] args)
    {
        double A = 0;
        for (double i = 2; i <= 112; i += 2)
        {
            A += (i / (i + 1));
        }
        Console.WriteLine(A);
    }
}


