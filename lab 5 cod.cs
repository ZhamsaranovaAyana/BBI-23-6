//номер 3
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matrixB = new int[5, 5]
//        {
//            {1, 2, 3, 4, 5},
//            {6, 7, 8, 9, 10},
//            {11, 12, 13, 14, 15},
//            {16, 17, 18, 19, 20},
//            {21, 22, 23, 24, 25}
//        };

//        int[,] matrixC = new int[6, 6]
//        {
//            {1, 2, 3, 4, 5, 6},
//            {7, 8, 9, 10, 11, 12},
//            {13, 14, 15, 16, 17, 18},
//            {19, 20, 21, 22, 23, 24},
//            {25, 26, 27, 28, 29, 30},
//            {31, 32, 33, 34, 35, 36}
//        };

//        DeleteRowWithMaxDiagonalElement(matrixB);
//        DeleteRowWithMaxDiagonalElement(matrixC);

//        Console.WriteLine("Матрица B после удаления строки с максимальным элементом на диагонали:");
//        PrintMatrix(matrixB);

//        Console.WriteLine("Матрица C после удаления строки с максимальным элементом на диагонали:");
//        PrintMatrix(matrixC);
//    }

//    static void DeleteRowWithMaxDiagonalElement(int[,] matrix)
//    {
//        int maxDiagonalElement = FindMaxDiagonalElement(matrix);

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            if (matrix[i, i] == maxDiagonalElement)
//            {

//                for (int j = i; j < matrix.GetLength(0) - 1; j++)
//                {
//                    for (int k = 0; k < matrix.GetLength(1); k++)
//                    {
//                        matrix[j, k] = matrix[j + 1, k];
//                    }
//                }

//                break;
//            }
//        }
//    }

//    static int FindMaxDiagonalElement(int[,] matrix)
//    {
//        int maxElement = matrix[0, 0];

//        for (int i = 1; i < matrix.GetLength(0); i++)
//        {
//            if (matrix[i, i] > maxElement)
//            {
//                maxElement = matrix[i, i];
//            }
//        }

//        return maxElement;
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
//        Console.WriteLine();
//    }
//}
//
//номер 9
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matrixA = {
//            {1, -2, 3, -4, 5},
//            {6, -7, 8, -9, 10},
//            {11, -12, 13, -14, 15},
//            {16, -17, 18, -19, 20},
//            {21, -22, 23, -24, 25},
//            {26, -27, 28, -29, 30}
//        };

//        int[,] matrixC = {
//            {31, -32, 33, -34},
//            {35, -36, 37, -38},
//            {39, -40, 41, -42},
//            {43, -44, 45, -46},
//            {47, -48, 49, -50},
//            {51, -52, 53, -54},
//            {55, -56, 57, -58}
//        };
//        int[] resultArray = SumPositiveColumns(matrixA).Concat(SumPositiveColumns(matrixC)).ToArray();


//        Console.WriteLine("Результат объединения массивов:");
//        foreach (var item in resultArray)
//        {
//            Console.Write(item + " ");
//        }
//    }

//    static int[] SumPositiveColumns(int[,] matrix)
//    {
//        int columns = matrix.GetLength(1);
//        int[] resultArray = new int[columns];

//        for (int j = 0; j < columns; j++)
//        {
//            int sum = 0;
//            for (int i = 0; i < matrix.GetLength(0); i++)
//            {
//                if (matrix[i, j] > 0)
//                {
//                    sum += matrix[i, j];
//                }
//            }
//            resultArray[j] = sum;
//        }

//        return resultArray;
//    }
//}
//
//номер 15
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[,] m1 = {
//            {3, 1, 5},
//            {4, 9, 2},
//            {7, 6, 8}
//        };

//        int[,] m2 = {
//            {12, 15, 9},
//            {6, 10, 8},
//            {14, 11, 13}
//        };

//        int[,] m3 = {
//            {20, 18, 22},
//            {24, 21, 19},
//            {23, 25, 17}
//        };

//        double[] resArray = {
//            CalcAvgWithoutMinMax(m1),
//            CalcAvgWithoutMinMax(m2),
//            CalcAvgWithoutMinMax(m3)
//        };


//        string seqType = IsIncSeq(resArray) ? "возрастающая" : "убывающая";


//        Console.WriteLine($"Средние значения без учета минимальных и максимальных элементов: {string.Join(", ", resArray)}");
//        Console.WriteLine($"Последовательность: {seqType}");
//    }

//    static double CalcAvgWithoutMinMax(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int columns = matrix.GetLength(1);

//        int min = matrix[0, 0];
//        int max = matrix[0, 0];
//        double sum = 0;
//        int count = 0;

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < columns; j++)
//            {
//                int current = matrix[i, j];
//                if (current < min)
//                    min = current;
//                if (current > max)
//                    max = current;

//                sum += current;
//                count++;
//            }
//        }


//        sum -= min;
//        sum -= max;


//        return sum / (count - 2);
//    }


//    static bool IsIncSeq(double[] array)
//    {
//        return array.SequenceEqual(array.OrderBy(x => x)) || array.SequenceEqual(array.OrderByDescending(x => x));
//    }
//}

//номер 21
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matrix1 = {
//            {3, 1, 5},
//            {4, 9, 2},
//            {7, 6, 8}
//        };

//        int[,] matrix2 = {
//            {12, 15, 9},
//            {6, 10, 8},
//            {14, 11, 13}
//        };

//        int[] resultArray1 = MinElementsRightOfDiagonal(matrix1);
//        int[] resultArray2 = MinElementsRightOfDiagonal(matrix2);


//        Console.WriteLine("Одномерный массив минимальных элементов для матрицы 1: " + string.Join(", ", resultArray1));
//        Console.WriteLine("Одномерный массив минимальных элементов для матрицы 2: " + string.Join(", ", resultArray2));
//    }


//    static int[] MinElementsRightOfDiagonal(int[,] matrix)
//    {
//        int size = matrix.GetLength(0);
//        int[] resultArray = new int[size];

//        for (int i = 0; i < size; i++)
//        {
//            int min = matrix[i, i]; 
//            for (int j = i + 1; j < size; j++)
//            {
//                if (matrix[i, j] < min)
//                {
//                    min = matrix[i, j];
//                }
//            }
//            resultArray[i] = min;
//        }

//        return resultArray;
//    }
//}
//
//номер 27
//using System;

//class Program
//{
//    static void Main()
//    {

//        int[,] matrix1 = {
//            {3, 1, 5},
//            {4, 9, 2},
//            {7, 6, 8}
//        };

//        int[,] matrix2 = {
//            {12, 15, 9},
//            {6, 10, 8},
//            {14, 11, 13}
//        };

//        Console.WriteLine("Исходная матрица 1:");
//        PrintMatrix(matrix1);

//        Console.WriteLine("Исходная матрица 2:");
//        PrintMatrix(matrix2);

//        ProcessMatrix(matrix1);
//        ProcessMatrix(matrix2);

//        Console.WriteLine("Матрица 1 после обработки:");
//        PrintMatrix(matrix1);

//        Console.WriteLine("Матрица 2 после обработки:");
//        PrintMatrix(matrix2);
//    }


//    static void ProcessMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int columns = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < columns; j++)
//            {
//                if (i % 2 == 0)
//                {

//                    if (matrix[i, j] == FindMaxInRow(matrix, i))
//                    {
//                        matrix[i, j] = 0;
//                    }
//                }
//                else
//                {
//                    matrix[i, j] *= j + 1;
//                }
//            }
//        }
//    }

//    static int FindMaxInRow(int[,] matrix, int row)
//    {
//        int max = matrix[row, 0];
//        for (int j = 1; j < matrix.GetLength(1); j++)
//        {
//            if (matrix[row, j] > max)
//            {
//                max = matrix[row, j];
//            }
//        }
//        return max;
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int columns = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < columns; j++)
//            {
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//    }
//}

