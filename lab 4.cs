//я 8-ая по списку, надеюсь что правильно посчитала номера заданий:1,5,9....
//1.1.
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[,] matrixA = new int[5, 7]
//        {
//            { 1, 2, 3, 4, 5, 6, 7 },
//            { 8, 9, 10, 11, 12, 13, 14 },
//            { 15, 16, 17, 18, 19, 20, 21 },
//            { 22, 23, 24, 25, 26, 27, 28 },
//            { 29, 30, 31, 32, 33, 34, 35 }
//        };

//        int sum = 0;
//        for (int i = 0; i < matrixA.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrixA.GetLength(1); j++)
//            {
//                sum += matrixA[i, j];
//            }
//        }

//        Console.WriteLine($"Сумма элементов матрицы A: {sum}");
//    }
//}


//1.5.
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[,] matrix = new int[5, 4] {
//            {1, -2, 3, 4},
//            {5, 6, -7, 8},
//            {-9, 10, 11, 12},
//            {13, 14, -15, 16},
//            {17, 18, 19, 20}
//        };

//        int colIndex = 2;

//        int negativeElement = -1;
//        int rowIndex = -1;

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            if (matrix[i, colIndex] < 0)
//            {
//                negativeElement = matrix[i, colIndex];
//                rowIndex = i;
//                break;
//            }
//        }

//        if (rowIndex >= 0)
//        {
//            Console.WriteLine("Значение первого отрицательного элемента в столбце {0} матрицы: {1}", colIndex, negativeElement);
//            Console.WriteLine("Номер строки: {0}", rowIndex);
//        }
//        else
//        {
//            Console.WriteLine("В столбце {0} нет отрицательных элементов", colIndex);
//        }
//    }
//}

//1.9
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[,] matrix = new int[5, 7]
//        {
//            { 1, 2, 3, 4, 5, 6, 7 },
//            { 8, 9, 10, 11, 12, 13, 14 },
//            { 15, 16, 17, 18, 19, 20, 21 },
//            { 22, 23, 24, 25, 26, 27, 28 },
//            { 29, 30, 31, 32, 33, 34, 35 }
//        };

//        int max = matrix[0, 0];
//        int maxRow = 0;
//        int maxCol = 0;

//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                if (matrix[i, j] > max)
//                {
//                    max = matrix[i, j];
//                    maxRow = i;
//                    maxCol = j;
//                }
//            }
//        }

//        int temp = matrix[0, 0];
//        matrix[0, 0] = max;
//        matrix[maxRow, maxCol] = temp;

//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//1.13
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[,] matrix = new int[5, 5]
//        {
//            {1, 2, 3, 4, 5},
//            {6, 7, 8, 9, 10},
//            {11, 12, 13, 14, 15},
//            {16, 17, 18, 19, 20},
//            {21, 22, 23, 24, 25}
//        };

//        int maxElement = matrix[0, 0];
//        int maxIndex = 0;

//        for (int i = 0; i < 5; i++)
//        {
//            if (matrix[i, i] > maxElement)
//            {
//                maxElement = matrix[i, i];
//                maxIndex = i;
//            }
//        }

//        for (int i = 0; i < 5; i++)
//        {
//            int temp = matrix[i, 3];
//            matrix[i, 3] = matrix[i, maxIndex];
//            matrix[i, maxIndex] = temp;
//        }

//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//1.17
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[,] matrix = 
//        {
//            {5, 8, 3, 10, 7, 2, 1},
//            {12, 6, 9, 4, 15, 11, 8},

//        };

//        ProcessMatrix(matrix);
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }

//    static void ProcessMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {

//            int minIndex = 0;
//            for (int j = 1; j < matrix.GetLength(1); j++)
//            {
//                if (matrix[i, j] < matrix[i, minIndex])
//                {
//                    minIndex = j;
//                }
//            }

//            int minElement = matrix[i, minIndex];
//            for (int j = minIndex; j > 0; j--)
//            {
//                matrix[i, j] = matrix[i, j - 1];
//            }
//            matrix[i, 0] = minElement;
//        }
//    }
//}

//1.21
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[,] matrix = 
//        {
//            {5, 8, 3, 10, 7, 2, 0},
//            {12, 6, 9, 4, 15, 11, 0},
//            {2, 4, 8, 6, 1, 7, 0},
//            {10, 3, 5, 7, 9, 2, 0},
//            {1, 6, 3, 8, 2, 5, 0}
//        };

//        ProcessMatrix(matrix);

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }

//    static void ProcessMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {

//            int maxElement = matrix[i, 0];
//            for (int j = 1; j < matrix.GetLength(1) - 1; j++)
//            {
//                if (matrix[i, j] > maxElement)
//                {
//                    maxElement = matrix[i, j];
//                }
//            }

//            matrix[i, matrix.GetLength(1) - 2] = maxElement;
//        }
//    }
//}

//1.25
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[,] matrix = 
//        {
//            {5, -2, 3, 10, -7},
//            {-12, 6, -9, -4, -15},
//            {2, 4, 8, 6, 1},
//            {-10, -3, 5, 7, -9},
//            {1, -6, 3, -8, 2},
//            {-4, -5, -2, -1, -3}
//        };

//        ProcessMatrix(matrix);

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }

//    static void ProcessMatrix(int[,] matrix)
//    {
//        int minNegCount = int.MaxValue;
//        int maxNegCount = int.MinValue;
//        int minNegRowIndex = -1;
//        int maxNegRowIndex = -1;

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            int negCount = CountNegativeElements(matrix, i);

//            if (negCount < minNegCount)
//            {
//                minNegCount = negCount;
//                minNegRowIndex = i;
//            }

//            if (negCount > maxNegCount)
//            {
//                maxNegCount = negCount;
//                maxNegRowIndex = i;
//            }
//        }

//        if (minNegRowIndex != maxNegRowIndex)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                int temp = matrix[minNegRowIndex, j];
//                matrix[minNegRowIndex, j] = matrix[maxNegRowIndex, j];
//                matrix[maxNegRowIndex, j] = temp;
//            }
//        }
//    }

//    static int CountNegativeElements(int[,] matrix, int rowIndex)
//    {
//        int count = 0;

//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            if (matrix[rowIndex, j] < 0)
//            {
//                count++;
//            }
//        }

//        return count;
//    }
//}

//1.29
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[,] F = 
//        {
//            {1, 2, 3, 4, 5, 6, 7},
//            {8, 9,10, 11, 12, 13, 14},
//            {15, 16, 17, 18, 19, 20, 21},
//            {22, 23, 24, 25, 26, 27, 28},
//            {29, 30, 31, 32, 33, 34, 35}
//        };

//        int minIndex = 0;
//        int minAbsValue = Math.Abs(F[1, 0]); 

//        for (int j = 1; j < F.GetLength(1); j++)
//        {
//            int absValue = Math.Abs(F[1, j]);
//            if (absValue < minAbsValue)
//            {
//                minAbsValue = absValue;
//                minIndex = j;
//            }
//        }

//        int[,] newF = new int[F.GetLength(0), F.GetLength(1) - 1];

//        for (int i = 0; i < F.GetLength(0); i++)
//        {
//            int newJ = 0;
//            for (int j = 0; j < F.GetLength(1); j++)
//            {
//                if (j != minIndex)
//                {
//                    newF[i, newJ] = F[i, j];
//                    newJ++;
//                }
//            }
//        }

//        Console.WriteLine("Исходная матрица F:");
//        PrintMatrix(F);
//        Console.WriteLine("Новая матрица без столбца с минимальным по модулю элементом во 2-й строке:");
//        PrintMatrix(newF);
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

//1.33
//using System;
//class Program
//{
//    static void Main()
//    {

//        int[,] matrixA = new int[5, 7]
//        {
//            { 1, -2, 3, -4, 5, 6, -7 },
//            { -8, 9, -10, 11, 12, -13, 14 },
//            { 15, -16, 17, 18, -19, 20, 21 },
//            { -22, 23, 24, -25, 26, 27, -28 },
//            { 29, -30, 31, 32, -33, 34, 35 }
//        };

//        int[] negativesArray = GetNegativeElements(matrixA);

//        Console.WriteLine("Отрицательные элементы матрицы A:");
//        foreach (int element in negativesArray)
//        {
//            Console.Write(element + " ");
//        }

//        Console.ReadLine();
//    }

//    static int[] GetNegativeElements(int[,] matrix)
//    {
//        int rowCount = matrix.GetLength(0);
//        int colCount = matrix.GetLength(1);
//        int[] negatives = new int[rowCount * colCount];
//        int count = 0;

//        for (int i = 0; i < rowCount; i++)
//        {
//            for (int j = 0; j < colCount; j++)
//            {
//                if (matrix[i, j] < 0)
//                {
//                    negatives[count] = matrix[i, j];
//                    count++;
//                }
//            }
//        }

//        Array.Resize(ref negatives, count); 
//        return negatives;
//    }
//}

//2.1
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[,] A = new int[5, 7]
//        {
//            {1, 2, 3, 4, 5, 6, 7},
//            {8, 9, 10, 11, 12, 13, 14},
//            {15, 16, 17, 18, 19, 20, 21},
//            {22, 23, 24, 25, 26, 27, 28},
//            {29, 30, 31, 32, 33, 34, 35}
//        };

//        for (int i = 0; i < 5; i++)
//        {
//            int maxIndex = 0;
//            int max = A[i, 0];

//            for (int j = 1; j < 7; j++)
//            {
//                if (A[i, j] > max)
//                {
//                    max = A[i, j];
//                    maxIndex = j;
//                }
//            }

//            if (maxIndex > 0 && maxIndex < 6)
//            {
//                if (A[i, maxIndex - 1] < A[i, maxIndex + 1])
//                {
//                    A[i, maxIndex - 1] *= 2;
//                }
//                else
//                {
//                    A[i, maxIndex + 1] *= 2;
//                }
//            }
//            else if (maxIndex == 0)
//            {
//                A[i, maxIndex + 1] *= 2;
//            }
//            else if (maxIndex == 6)
//            {
//                A[i, maxIndex - 1] *= 2;
//            }
//        }

//        Console.WriteLine("Измененная матрица A:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write(A[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//2.5
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[,] matrixA = {
//            {1, 2, 3, 4, 5},
//            {6, 7, 8, 9, 10},
//            {11, 12, 13, 14, 15},
//            {16, 17, 18, 19, 20},
//            {21, 22, 23, 24, 25},
//            {26, 27, 28, 29, 30},
//            {31, 32, 33, 34, 35}
//        };

//        for (int column = 0; column < 5; column++)
//        {
//            int maxElement = matrixA[0, column];
//            int maxElementRow = 0;

//            for (int row = 1; row < 7; row++)
//            {
//                if (matrixA[row, column] > maxElement)
//                {
//                    maxElement = matrixA[row, column];
//                    maxElementRow = row;
//                }
//            }

//            int halfSum = (matrixA[0, column] + matrixA[6, column]) / 2;

//            if (maxElement < halfSum)
//            {
//                matrixA[maxElementRow, column] = halfSum;
//            }
//            else
//            {
//                matrixA[maxElementRow, column] = column;
//            }
//        }

//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write(matrixA[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//2.9
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[,] matrixA = new int[6, 7]
//        {
//            {1, 2, 3, 4, 5, 6, 7},
//            {8, 9, 10, 11, 12, 13, 14},
//            {15, 16, 17, 18, 19, 20, 21},
//            {22, 23, 24, 25, 26, 27, 28},
//            {29, 30, 31, 32, 33, 34, 35},
//            {36, 37, 38, 39, 40, 41, 42}
//        };

//        for (int i = 0; i < matrixA.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrixA.GetLength(1) / 2; j++)
//            {
//                int temp = matrixA[i, j];
//                matrixA[i, j] = matrixA[i, matrixA.GetLength(1) - 1 - j];
//                matrixA[i, matrixA.GetLength(1) - 1 - j] = temp;
//            }
//        }

//        for (int i = 0; i < matrixA.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrixA.GetLength(1); j++)
//            {
//                Console.Write(matrixA[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//3.1
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matrix = {
//            {3, 7, 2, 9, 4},
//            {5, 1, 8, 6, 0},
//            {10, 3, 5, 2, 1},
//            {4, 3, 6, 7, 2},
//            {1, 9, 4, 2, 5},
//            {6, 4, 5, 3, 8},
//            {2, 5, 1, 3, 7}
//        };

//        int[] minElements = new int[7];

//        for (int i = 0; i < 7; i++)
//        {
//            int min = matrix[i, 0];
//            for (int j = 1; j < 5; j++)
//            {
//                if (matrix[i, j] < min)
//                {
//                    min = matrix[i, j];
//                }
//            }
//            minElements[i] = min;
//        }

//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = i + 1; j < 7; j++)
//            {
//                if (minElements[j] < minElements[i])
//                {
//                    int temp = minElements[i];
//                    minElements[i] = minElements[j];
//                    minElements[j] = temp;

//                    for (int k = 0; k < 5; k++)
//                    {
//                        temp = matrix[i, k];
//                        matrix[i, k] = matrix[j, k];
//                        matrix[j, k] = temp;
//                    }
//                }
//            }
//        }

//        Console.WriteLine("Матрица с переставленными строками:");
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//3.2.
//using System;
//class Program
//{
//    static void Main()
//    {
//        int n = 5;
//        int[,] matrix = new int[n, n];

//        Random rand = new Random();
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                matrix[i, j] = rand.Next(1, 10);
//            }
//        }

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix, n);

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                if (i == 0 || j == 0 || i == n - 1 || j == n - 1)
//                {
//                    matrix[i, j] = 0;
//                }
//            }
//        }

//        Console.WriteLine("Матрица с нулями на периметре:");
//        PrintMatrix(matrix, n);

//    }

//    static void PrintMatrix(int[,] matrix, int n)
//    {
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}
