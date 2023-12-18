//исправленные номера 3,15,27
//номер 3
//using System;

//class Program
//{

//    static void Main()
//    {
//        int[,] B = GenerateRandomMatrix(5, 5);
//        int[,] C = GenerateRandomMatrix(6, 6);

//        Console.WriteLine("Исходная матрица B:");
//        PrintMatrix(B);

//        Console.WriteLine("Исходная матрица C:");
//        PrintMatrix(C);

//        B = RemoveRowWithMaxDiagonalElement(B);
//        C = RemoveRowWithMaxDiagonalElement(C);

//        Console.WriteLine("Матрица B после удаления строки с максимальным элементом на диагонали:");
//        PrintMatrix(B);

//        Console.WriteLine("Матрица C после удаления строки с максимальным элементом на диагонали:");
//        PrintMatrix(C);
//    }

//    static int[,] GenerateRandomMatrix(int rows, int cols)
//    {
//        Random random = new Random();
//        int[,] matrix = new int[rows, cols];

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                matrix[i, j] = random.Next(1, 100);
//            }
//        }

//        return matrix;
//    }

//    static int[,] RemoveRowWithMaxDiagonalElement(int[,] matrix)
//    {
//        int maxElement = matrix[0, 0];
//        int maxRowIndex = 0;

//        for (int i = 1; i < Math.Min(matrix.GetLength(0), matrix.GetLength(1)); i++)
//        {
//            if (matrix[i, i] > maxElement)
//            {
//                maxElement = matrix[i, i];
//                maxRowIndex = i;
//            }
//        }

//        int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];

//        for (int i = 0, newRow = 0; i < matrix.GetLength(0); i++)
//        {
//            if (i != maxRowIndex)
//            {
//                for (int j = 0; j < matrix.GetLength(1); j++)
//                {
//                    newMatrix[newRow, j] = matrix[i, j];
//                }
//                newRow++;
//            }
//        }

//        return newMatrix;
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//номер 15
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//        int[,] matrix2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
//        int[,] matrix3 = { { 5, 5, 5 }, { 5, 5, 5 }, { 5, 5, 5 } };

//        double[] averages = new double[3];
//        averages[0] = CalculateAverage(matrix1);
//        averages[1] = CalculateAverage(matrix2);
//        averages[2] = CalculateAverage(matrix3);

//        Array.Sort(averages);

//        if (IsIncreasingSequence(averages))
//        {
//            Console.WriteLine("Полученные значения образуют возрастающую последовательность");
//        }
//        else if (IsDecreasingSequence(averages))
//        {
//            Console.WriteLine("Полученные значения образуют убывающую последовательность");
//        }
//        else
//        {
//            Console.WriteLine("Полученные значения не образуют убывающую или возрастающую последовательность");
//        }
//    }

//    static double CalculateAverage(int[,] matrix)
//    {
//        int min = int.MaxValue;
//        int max = int.MinValue;
//        double sum = 0;
//        int count = 0;

//        foreach (int element in matrix)
//        {
//            if (element < min)
//            {
//                min = element;
//            }
//            if (element > max)
//            {
//                max = element;
//            }
//            sum += element;
//            count++;
//        }

//        sum -= (min + max);
//        count -= 2;

//        return sum / count;
//    }

//    static bool IsIncreasingSequence(double[] array)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            if (array[i] > array[i + 1])
//            {
//                return false;
//            }
//        }
//        return true;
//    }

//    static bool IsDecreasingSequence(double[] array)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            if (array[i] < array[i + 1])
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//}
//номер 27
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//        int[,] matrix2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

//        ProcessMatrix(matrix1);
//        ProcessMatrix(matrix2);

//        PrintMatrix(matrix1);
//        PrintMatrix(matrix2);
//    }

//    static void ProcessMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            int maxElement = int.MinValue;
//            int maxElementColumn = 0;
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                if (matrix[i, j] > maxElement)
//                {
//                    maxElement = matrix[i, j];
//                    maxElementColumn = j;
//                }
//            }
//            if (i % 2 == 1) 
//            {
//                matrix[i, maxElementColumn] = 0;
//            }
//            else
//            {
//                matrix[i, maxElementColumn] *= maxElementColumn + 1;
//            }
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//    }
//}


