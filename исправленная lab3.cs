using System;

class Programm
{
    static void Main(string[] args)
    {


        //2.11
        //Console.WriteLine("введите количество элементов массива: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] a = new int[n];
        //Console.WriteLine("введите число P: ");
        //int p = int.Parse(Console.ReadLine());
        //Console.WriteLine("введите элементы массива:");
        //int lastIndex = -1;
        //for (int i = 0; i < n; i++)
        //{
        //    string s = Console.ReadLine();
        //    a[i] = int.Parse(s);
        //    if (a[i] > 0)
        //    {
        //        lastIndex = i;
        //    }
        //}
        //if (lastIndex >= 0)
        //{
        //    int[] b = new int[n + 1];
        //    for (int i = 0; i <= lastIndex; i++)
        //    {
        //        b[i] = a[i];
        //    }
        //    b[lastIndex + 1] = p;
        //    for (int i = lastIndex + 2; i < n + 1; i++)
        //    {
        //        b[i] = a[i - 1];
        //    }
        //    a = b;
        //    n++;
        //    Console.WriteLine("полученный массив:");
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write("{0} ", a[i]);
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("в массиве нет положительных элементов.");
        //}

        //// 2.12
        //double[] a = new double[5];
        //double max = -100000;
        //int ni = 0;
        //for (int i = 0; i < a.Length; i++)
        //{
        //    a[i] = double.Parse(Console.ReadLine());
        //    if (a[i] > max)
        //    {
        //        max = a[i];
        //        ni = i;
        //    }
        //}
        //double sum = 0;
        //for (int i = ni+1; i < a.Length; i++)
        //{
        //    sum += a[i];
        //}
        //for (int i = 0; i < a.Length; i++)
        //{
        //    if (a[i] < 0)
        //    {
        //        a[i] = sum;
        //        break;
        //    }
        //}
        //for (int i = 0; i < a.Length; i++)
        //{
        //    Console.WriteLine("{0:f}", a[i]);
        //}


        //// 2.14
        //Console.WriteLine("введите количество элементов массива: ");
        //int n = int.Parse(Console.ReadLine());
        //Console.WriteLine("введите элемены массива: ");
        //int[] a = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    string s = Console.ReadLine();
        //    a[i] = int.Parse(s);
        //}
        //int amax = a[0];
        //int imax = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    if (a[i] > amax)
        //    {
        //        amax = a[i];
        //        imax = i;
        //    }
        //}
        //int k = -1;
        //for (int i = 0; i < n; i++)
        //{
        //    if (a[i] < 0)
        //    {
        //        k = i;
        //        break;
        //    }
        //}
        //if (imax >= 0 && k >= 0)
        //{
        //    int t = a[imax];
        //    a[imax] = a[k];
        //    a[k] = t;
        //    Console.WriteLine("полученный массив:");
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.WriteLine(a[i]);
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("нет максимальных или отрицательных элементов.");
        //}

        //// 2.15
        //Console.WriteLine("введите n: ");
        //int n = int.Parse(Console.ReadLine());
        //Console.WriteLine("введите массив: ");
        //int[] a = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    string s = Console.ReadLine();
        //    a[i] = int.Parse(s);
        //}
        //Console.WriteLine("введите m: ");
        //int m = int.Parse(Console.ReadLine());
        //Console.WriteLine("введите массив: ");
        //int[] b = new int[m];
        //for (int i = 0; i < m; i++)
        //{
        //    string s1 = Console.ReadLine();
        //    b[i] = int.Parse(s1);
        //}
        //int[] c = new int[n + m];
        //Console.WriteLine("введите k: ");
        //int k = int.Parse(Console.ReadLine());
        //if (k >= a.Length)
        //{
        //    Console.WriteLine("такого элемента не существует в массиве");
        //}
        //else
        //{
        //    for (int i = 0; i <= k; i++)
        //    {
        //        c[i] = a[i];
        //    }
        //    for (int i = 0; i < m; i++)
        //    {
        //        c[k + i + 1] = b[i];
        //    }
        //    for (int i = k + m + 1; i < m + n; i++)
        //    {
        //        c[i] = a[i - m];
        //    }
        //    Console.WriteLine("полученный массив: ");
        //    for (int i = 0; i < m + n; i++)
        //    {
        //        Console.WriteLine(c[i]);
        //    }
        //}



        //// 2.17
        //double[] a = new double[5];
        //double sr = 0;
        //int k = 0;
        //double sum = 0;
        //double max = -10000;
        //double min = 100000;
        //int ni1 = 0;
        //int ni2 = 0;
        //for (int i = 0; i < a.Length; i++)
        //{
        //    a[i] = double.Parse(Console.ReadLine());
        //    if (a[i] > max)
        //    {
        //        max = a[i];
        //        ni1 = i;
        //    }
        //    if (a[i] < min)
        //    {
        //        min = a[i];
        //        ni2 = i;
        //    }
        //}
        //if (ni1 < ni2)
        //{
        //    for (int i = 0; i < a.Length; ++i)
        //    {
        //        if (a[i] > 0)
        //        {
        //            sum += a[i];
        //            k++;
        //        }
        //    }
        //}
        //else
        //{
        //    for (int i = 0; i < a.Length; ++i)
        //    {
        //        if (a[i] < 0)
        //        {
        //            sum += a[i];
        //            k++;
        //        }
        //    }
        //}
        //if (k == 0)
        //{
        //    Console.WriteLine("нет положительных или отрицательных элементов");
        //}
        //else
        //{
        //    sr = sum / k;
        //    Console.WriteLine(sr);
        //}
    }
}
       