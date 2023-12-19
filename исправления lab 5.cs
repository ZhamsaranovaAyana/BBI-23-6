//номер 15
using System;
class Program
{
    static void Main()
    {
        int[,] matrix1 = { { 1, 2, 3 } };
        int[,] matrix2 = { { 9, 8 } };
        int[,] matrix3 = { { 5, 5, 5 }, { 5, 5, 5 }, { 5, 5, 5 } };

        double[] averages = new double[3];
        averages[0] = CalculateAverageWithoutMinMax(matrix1);
        averages[1] = CalculateAverageWithoutMinMax(matrix2);
        averages[2] = CalculateAverageWithoutMinMax(matrix3);

        CheckSequence(averages);
    }

    static void CheckSequence(double[] averages)
    {
        
        foreach (var average in averages)
        {
            Console.WriteLine(average);
        }
    }

    static double CalculateAverageWithoutMinMax(int[,] matrix)
    {
        int min = matrix[0, 0];
        int max = matrix[0, 0];
        double sum = 0;
        int count = 0;
        foreach (int element in matrix)
        {
            if (element < min)
                min = element;
            if (element > max)
                max = element;
            sum += element;
            count++;
        }

        sum -= min + max;
        count -= 2;

        double average = count > 0 ? sum / count : 0;
        return average;
    }
}
