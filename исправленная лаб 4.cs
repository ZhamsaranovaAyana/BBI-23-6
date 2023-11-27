////2.5
//double[,] a = new double[7, 5];
//double max;
//double sum = 0;
//int im = -1;
//for (int i = 0; i < a.GetLength(0); i++)
//{
//    for (int j = 0; j < a.GetLength(1); j++)
//    {
//        Console.WriteLine("[" + i + "," + j + "]");
//        a[i, j] = Double.Parse(Console.ReadLine());
//    }
//    Console.WriteLine();
//}

//for (int j = 0; j < a.GetLength(1); j++)
//{
//    im = 0;
//    max = a[0, j];
//    sum = (a[0, j] + a[a.GetLength(0) - 1, j]) / 2;
//    for (int i = 0; i < a.GetLength(0); i++)
//    {
//        if (a[i, j] > max)
//        {
//            im = i;
//            max = a[i, j];
//        }
//    }
//    if (a[im, j] < sum) a[im, j] = sum;
//    else a[im, j] = im + 1;
//}

//Console.WriteLine();
//for (int i = 0; i < a.GetLength(0); i++)
//{
//    for (int j = 0; j < a.GetLength(1); j++)
//    {
//        Console.Write(a[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//3.1
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matrix = new int[7, 5]
//        {
//            {3, 5, 2, 8, 1},
//            {9, 4, 6, 2, 7},
//            {1, 2, 3, 4, 5},
//            {7, 6, 5, 4, 3},
//            {8, 9, 2, 1, 6},
//            {5, 3, 7, 2, 1},
//            {4, 6, 8, 9, 5}
//        };

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            int minIndex = FindMinIndex(matrix, i);
//            if (minIndex != i)
//            {
//                SwapRows(matrix, i, minIndex);
//            }
//        }

//        PrintMatrix(matrix);
//    }

//    static int FindMinIndex(int[,] matrix, int row)
//    {
//        int minIndex = row;
//        int minValue = matrix[row, 0];
//        for (int i = 1; i < matrix.GetLength(1); i++)
//        {
//            if (matrix[row, i] < minValue)
//            {
//                minIndex = row;
//                minValue = matrix[row, i];
//            }
//        }
//        return minIndex;
//    }

//    static void SwapRows(int[,] matrix, int row1, int row2)
//    {
//        for (int i = 0; i < matrix.GetLength(1); i++)
//        {
//            int temp = matrix[row1, i];
//            matrix[row1, i] = matrix[row2, i];
//            matrix[row2, i] = temp;
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
//    }
//}