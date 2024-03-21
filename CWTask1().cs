
using System;

struct Point
{
    public double X { get; }
    public double Y { get; }

    public Point(double[] coordinates)
    {
        if (coordinates.Length != 2)
        {
            throw new ArgumentException("Координаты могут содержать только 2 переменные.");
        }
        X = coordinates[0];
        Y = coordinates[1];
    }

    public static double Distance(Point point1, Point point2)
    {
        double deltaX = point2.X - point1.X;
        double deltaY = point2.Y - point1.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }

    public static void PrintDistance(Point point1, Point point2)
    {
        Console.WriteLine($"Координаты точки 1: ({point1.X}, {point1.Y})");
        Console.WriteLine($"Коордианты точки 2: ({point2.X}, {point2.Y})");
        Console.WriteLine($"Расстояние между точками: {Distance(point1, point2):F2}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Point[] points = new Point[3];
        points[0] = new Point(new double[] { 0, 0 });
        points[1] = new Point(new double[] { 3, 4 });
        points[2] = new Point(new double[] { -2, 6 });
        for (int i = 0; i < points.Length - 1; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                Point.PrintDistance(points[i], points[j]);
            }
        }
    }
}
