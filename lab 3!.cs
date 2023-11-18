//// 1 уровень
// 1
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[6];
//        string s;
//        for (int i = 0; i < 6; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double sum = 0;
//        for (int i = 0; i < 6; i++)
//        {
//            sum += a[i];
//        }
//        Console.WriteLine(sum);
//        if (sum != 0)
//        {
//            for (int i = 0; i < 6; i++)
//            {
//                a[i] /= sum;
//            }
//            Console.WriteLine("массив полученный: ");
//            for (int i = 0; i < 6; i++)
//            {
//                Console.WriteLine(a[i]);
//            }
//        }
//    }
//}

//2
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[8];
//        string s;
//        double sum = 0;
//        int m = 0;
//        double sr;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < 8; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        for (int i = 0; i < 8; i++)
//        {
//            if (a[i]>0)
//            {
//                sum += a[i];
//                m += 1;
//            }
//        }
//        sr = sum / m;
//        Console.WriteLine("cреднее арифметическое");
//        Console.WriteLine(sr);
//        for(int i=0; i < 8; i++)
//        {
//            if (a[i]>0)
//            {
//                a[i] = sr;
//            }
//        }
//        Console.WriteLine("массив после изменения");
//        for (int i = 0; i < 8; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}

//3
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[4];
//        double[] b = new double[4];
//        double[] c = new double[4];
//        double[] d = new double[4];
//        string k;
//        Console.WriteLine("массив a");
//        for (int i = 0; i < 4; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        Console.WriteLine("массив b");
//        for (int i = 0; i < 4; i++)
//        {
//            k = Console.ReadLine();
//            b[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 4; i++)
//        {
//            c[i] = a[i] + b[i];
//        }
//        for (int i = 0; i < 4; i++)
//        {
//            d[i] = a[i] - b[i];
//        }
//        Console.WriteLine("массив с");
//        for (int i = 0; i < 4; i++)
//        {
//            Console.WriteLine(c[i]);
//        }
//        Console.WriteLine("массив d");
//        for (int i = 0; i < 4; i++)
//        {
//            Console.WriteLine(d[i]);
//        }
//    }
//}

//4
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[5];
//        string k;
//        double sum = 0;
//        int m = 0;
//        double sr;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < 5; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            sum += a[i];
//            m += 1;
//        }
//        sr = sum / m;
//        Console.WriteLine("среднее арифметиечское");
//        Console.WriteLine(sr);
//        for (int i = 0; i < 5; i++)
//        {
//            a[i] = a[i] - sr;
//        }
//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}

//5
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[4];
//        double[] b = new double[4];
//        double[] c = new double[4];
//        string k;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < 4; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        Console.WriteLine("введите массив b");
//        for (int i = 0; i < 4; i++)
//        {
//            k = Console.ReadLine();
//            b[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 4; i++)
//        {
//            c[i] = a[i] + b[i];
//        }
//        Console.WriteLine("скалярное произведение");
//        for (int i = 0; i < 4; i++)
//        {
//            Console.WriteLine(c[i]);
//        }
//    }
//}

//6
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[5];
//        string k;
//        double l = 0;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < 5; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            l = l + a[i] * a[i];
//        }
//        Console.WriteLine(Math.Sqrt(l));
//    }
//}

//7
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[7];
//        string k;
//        double sum = 0;
//        int m = 0;
//        double sr;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < 7; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 7; i++)
//        {
//            sum = sum + a[i];
//            m += 1;
//        }
//        sr = sum / m;
//        Console.WriteLine("среднее арифметическое");
//        Console.WriteLine(sr);
//        for(int i=0; i<7; i++)
//        {
//            if (a[i]>sr)
//            {
//                a[i] = 0;
//            }
//        }
//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < 7; i++)
//        {
//            Console.WriteLine(a[i]);
//        }

//    }
//}

//8
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[6];
//        string k;
//        int m = 0;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < 6; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 6; i++)
//        {
//            if (a[i] < 0)
//            {
//                m+=1;
//            }
//        }
//        Console.WriteLine(m);

//    }
//}

//9
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[8];
//        string k;
//        double sum = 0;
//        int m = 0;
//        int n = 0;
//        double sr;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < 8; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 8; i++)
//        {
//            sum = sum + a[i];
//            m += 1;
//        }
//        sr = sum / m;
//        Console.WriteLine("среднее арифметическое");
//        Console.WriteLine(sr);
//        for (int i = 0; i < 8; i++)
//        {
//            if (a[i] > sr)
//            {
//                n += 1;
//            }
//        }
//        Console.WriteLine("количество элементов, больших sr");
//        Console.WriteLine(n);

//    }
//}

//10
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[10];
//        string k;
//        int m = 0;
//        Console.WriteLine("введите P");
//        double P = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("введите Q при P<Q");
//        double Q = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < 10; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 10; i++)
//        {
//            if (P > a[i] && a[i]<Q)
//            {
//                m += 1;
//            }
//        }
//        Console.WriteLine("количество во элементов, удовлетворяющих условию");
//        Console.WriteLine(m);

//    }
//}

//11
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[10];
//        double[] b = new double[10];
//        string k;
//        int m = 0;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < 10; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 10; i++)
//        {
//            if (a[i]>=0)
//            {
//                b[m] = a[i];
//                m += 1;
//            }
//        }
//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine(b[i]);
//        }

//    }
//}

//12
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[8];
//        string k;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < 8; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amin = a[0];
//        int imin = 0;
//        for (int i=1; i<8; i++)
//        {
//            if (a[i]<amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("значение последнего отрицательного элемента");
//        Console.WriteLine(amin);
//        Console.WriteLine("индекс последнего отрицательного элемента");
//        Console.WriteLine(imin);
//    }
//}

//13
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[10];
//        double[] b = new double[5];
//        double[] c = new double[5];
//        string k;
//        int m = 0;
//        int n = 0;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < 10; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 10; i=i+2)
//        {
//            b[m] = a[i] ;
//            m++;
//        }
//        for (int i = 1; i < 10; i = i + 2)
//        {
//            c[n] = a[i];
//            n++;
//        }
//        Console.WriteLine("массив по четным индексам");
//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine(b[i]);
//        }
//        Console.WriteLine("массив по нечетным индексам");
//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine(c[i]);
//        }
//    }
//}

//14
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[11];
//        string k;
//        double sum = 0;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < 11; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 11; i++)
//        {
//            if (a[i]>0)
//            {
//                sum = sum + a[i] * a[i];
//            }
//            else
//            {
//                break;
//            }
//        }
//        Console.WriteLine(sum);
//    }
//}

//15
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] x = new double[10];
//        double[] y = new double[10];
//        string k;
//        Console.WriteLine("введите массив-x");
//        for (int i = 0; i < 10; i++)
//        {
//            k = Console.ReadLine();
//            x[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 10; i++)
//        {
//            y[i] = 0.5 * Math.Log(x[i]);
//        }
//        Console.WriteLine(" ");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine($"{x[i]} {y[i]}");
//        }
//    }
//}
//
////2 уровень 
//1
//using System;
//using System.Collections.Immutable;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("введите количествово элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;

//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amin = a[0];
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] <= amin)
//            {
//                amin = a[i];
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] == amin)
//            {
//                a[i] = a[i] * a[i];
//            }
//        }
//        Console.WriteLine("min элемент массива");
//        Console.WriteLine(amin);
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }

//    }
//}

//2
//using System;

//class Programm
//{
//        static void Main(string[] args)
//        {
//            Console.WriteLine("введите количествово элементов массива: ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("введите массив: ");
//            double[] a = new double[n];
//            string s;
//            for (int i = 0; i < n; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double amax = a[0];
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] > amax)
//                {
//                    amax = a[i];
//                }
//            }
//            Console.WriteLine("максимальный элемент массива: ");
//            Console.WriteLine(amax);
//            double s1 = 0;
//            foreach (double x in a)
//            {
//                if (x < amax)
//                {
//                    s1 = s1 + x;
//                }
//                else
//                {
//                    break;
//                }
//            }
//            Console.WriteLine("сумма элементов массива до максимального: ");
//            Console.WriteLine(s1);
//        }
//    }
//}
//
//3
//using System;
//class Programm
//{
//        static void Main(string[] args)
//        {
//            Console.WriteLine("введите количествово элементов массива: ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("введите массив: ");
//            int[] a = new int[n];
//            string s;
//            for (int i = 0; i < n; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = int.Parse(s);
//            }
//            int amin = a[0];
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] < amin)
//                {
//                    amin = a[i];
//                }
//            }
//            Console.WriteLine("минимальный элемент массива: ");
//            Console.WriteLine(amin);
//            for (int i = 0;i < n; i++)
//            {
//                if (amin < a[i])
//                {
//                    a[i] *= 2;
//                }
//            }
//            Console.WriteLine("увеличенные вдвое элементы массива: ");
//            foreach (int element in a)
//            {
//                Console.Write(element + " ");
//            }
//        }
//    }
//}

// 4
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("введите количествово элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;

//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amax = a[0];
//        double sum = 0;
//        int m = 0;
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum = sum + a[i];
//            m += 1;
//        }
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] >= amax)
//            {
//                amax = a[i];
//                imax = i;

//            }
//        }
//        double sr = sum / m;
//        Console.WriteLine("среднее арифметическое");
//        Console.WriteLine(sr);
//        Console.WriteLine("максимальный элемент");
//        Console.WriteLine(amax);
//        for (int i = 0; i < n; i++)
//        {
//            if (i>=imax)
//            {
//                a[i] = sr;
//            }
//        }
//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }

//    }
//}

//5
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("введите количествово элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        double[] b = new double[n];
//        string k;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amax = a[0];
//        int imax = 0;
//        double amin = a[0];
//        int imin = 0;
//        int m = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] >= amax)
//            {
//                amax = a[i];
//                imax = i;

//            }
//            if (a[i] <= amin)
//            {
//                amin = a[i];
//                imin = i;

//            }
//        }
//        Console.WriteLine("минимальный элемент");
//        Console.WriteLine(amin);
//        Console.WriteLine("максимальный элемент");
//        Console.WriteLine(amax);
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i]<0)
//            {
//                if (a[i]>amin && a[i]<amax)
//                {
//                    b[m] = a[i];
//                    m += 1;
//                }
//            }
//        }
//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(b[i]);
//        }

//    }
//}

//6
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("введите количество элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n+1];
//        string k;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        Console.WriteLine("введите число P");
//        double P = Convert.ToDouble(Console.ReadLine());
//        double sr;
//        double sum = 0;
//        int m = 0;
//        double minR = 10000000000000000000;
//        double curD = 0;
//        int ind = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum = sum + a[i];
//            m += 1;
//        }
//        sr = sum / m;
//        Console.WriteLine("среднее арифметическое");
//        Console.WriteLine(sr);
//        for (int i = 0; i < n; i++)
//        {
//            curD = Math.Abs(sr - a[i]);
//            if (curD<minR)
//            {
//                minR = curD;
//                ind = i;
//            }
//        }
//        for (int i = n; i >= ind+2 ; i--)
//        {
//            a[i] = a[i - 1];
//        }
//        a[ind+1] = P;
//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < n+1; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

//7
//using System;
//   class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("ведите количество элементов массива: ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("введите массив: ");
//            int[] a = new int[n];
//            string s;
//            for (int i = 0; i < n; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = int.Parse(s);
//            }
//            int amax = a[0];
//            int imax = 0;
//            for (int i = 0;i < n; i++)
//            {
//                if (a[i] > amax)
//                {
//                    amax = a[i];
//                    imax = i;
//                }
//            }
//            Console.WriteLine("максимальный элемент массива: ");
//            Console.WriteLine(amax);
//            if (imax < n - 1)
//            {
//                a[imax + 1] *= 2;
//                Console.WriteLine("элемент, увеличенный в 2 раза: ");
//                Console.WriteLine(a[imax + 1]);
//            }
//            else
//            {
//                Console.WriteLine("максимальный элемент находится в последней позиции массива");
//            }
//        }
//    }
//}

// 8
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("введите количество элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amax = a[0];
//        int imax = 0;

//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        double amin = a[imax+1];
//        int imin = imax+1;
//        Console.WriteLine("максимальный элемент массива");
//        Console.WriteLine(amax);
//        for (int i = imax+1 ; i < n ; i++)
//        {
//            if (a[i]<amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("минимальный элемент массива");
//        Console.WriteLine(amin);
//        double v = amin;
//        a[imin] = amax;
//        a[imax] = v;
//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// 9
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("введите количество элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amax = a[0];
//        int imax = 0;
//        double amin = a[0];
//        int imin = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (amax < a[i])
//            {
//                amax = a[i];
//                imax = i;
//            }
//            if (a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("максимальный элемент массива");
//        Console.WriteLine(amax);
//        Console.WriteLine("минимальный элемент массива");
//        Console.WriteLine(amin);
//        double sum = 0;
//        int m = 0;
//        double sr;
//        int min, max;
//        if (imin < imax)
//        {
//            min = imin;
//            max = imax;
//        }
//        else if (imin > imax)
//        {
//            min = imax;
//            max = imin;
//        }
//        else
//        {
//            min = imax;
//            max = imin;
//        }
//        for (int i = min+1; i < max; i++)
//        {
//            sum = sum + a[i];
//            m = m + 1;
//        }
//        sr = sum / m;
//        Console.WriteLine("среднее арифметическое чисел ");
//        Console.WriteLine(sr);
//    }
//}

// 10
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("введите количество элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amin = a[0];
//        int imin = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > 0 && a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("минимальный элемент массива");
//        Console.WriteLine(amin);
//        for (int i = imin; i < n-1; i++)
//        {
//            a[i] = a[i + 1];
//        }

//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < n-1; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// 11
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("введите количество элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n+1];
//        string k;
//        Console.WriteLine("введите число Р");
//        double P = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        int idx = 0;
//        for (int i = n-1; i >= 0; i--)
//        {
//            if (a[i] > 0)
//            {
//                idx = i;
//                break;
//            }
//        }
//        for (int i = n; i > idx+1; i--)
//        {
//            a[i] = a[i-1];
//        }
//        a[idx+1] = P;
//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < n + 1; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// 12
//using System;

//class Programm
//{
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("введите количество элементов массива: ");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("введите массив: ");
//            int[] a = new int[n];
//            string s;
//            for (int i = 0; i < n; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = int.Parse(s);
//            }
//            int amax = a[0];
//            int imax = 0;
//            for (int i = 1; i < n ; i++)
//            {
//                if (a[i] > amax)
//                {
//                    amax = a[i];
//                    imax = i;
//                }
//            }
//            Console.WriteLine("максимальный элемент массива: ");
//            Console.WriteLine(amax);
//            int k = -1;
//            for (int i = imax + 1 ;i < n ; i++)
//            {
//                if (a[i] < 0)
//                {
//                    k = i;
//                    break;
//                }
//            }
//            if (k != -1)
//            {
//                int sum = 0;
//                for (int i = k + 1; i < n; i++)
//                {
//                    sum += a[i];
//                }
//                a[k] = sum;
//                Console.WriteLine("массив после замены:");
//                for (int i = 0; i < n; i++)
//                {
//                    Console.Write(a[i] + " ");
//                }
//            }
//            else
//            {
//                Console.WriteLine("в массиве нет отрицательных элементов после максимального");
//            }
//        }
//    }
//}

// 13
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("введите количество элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        int idx = 0;
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i=i+2)
//        {
//            if (amax < a[i])
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        a[imax] = imax+1; //т.к. в жизни индексы с 1, а не с 0 как в массивах
//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

//14
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("введите количество элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;
//        double neg = 0;
//        Console.WriteLine("введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        int idx = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < 0)
//            {
//                neg = a[i];
//                idx = i;
//                break;
//            }
//        }
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (amax < a[i])
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        a[imax] = neg;
//        a[idx] = amax;
//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// 15
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("введите количество элементов массива B");
//        int m = Convert.ToInt32(Console.ReadLine());
//        double[] b = new double[m];
//        Console.WriteLine("введите массив B");
//        for (int i = 0; i < m; i++)
//        {
//            p = Console.ReadLine();
//            b[i] = double.Parse(p);
//        }
//        Console.WriteLine("введите количество элементов массива A");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n+m];
//        Console.WriteLine("введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        Console.WriteLine("введите число k");
//        int k = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i <= n-k-1; i++)
//        {
//            a[k+m+i] = a[k+i];
//        }
//        for (int i = 0; i < m ; i++)
//        {
//            a[k + i] = b[i];
//        }
//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < m + n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// 16
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("введите количество элементов массива A");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        double[] b = new double[n];
//        Console.WriteLine("введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        double sum = 0;
//        int m = 0;
//        double sr;
//        double minR = 10000000000000000000;
//        double curD = 0;
//        int ind = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum = sum + a[i];
//            m += 1;
//        }
//        sr = sum / m;
//        Console.WriteLine("среднее арифметическое");
//        Console.WriteLine(sr);
//        int l = 0;
//        for (int i=0; i<n; i++)
//        {
//            if (a[i]<sr)
//            {
//                b[l] = i;
//                l+= 1;
//            }
//        }
//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < l; i++)
//        {
//            Console.Write($"{b[i]} ");
//        }

//    }
//}

// 17
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("введите количество элементов массива A");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        Console.WriteLine("введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        double sum = 0;
//        int m = 0;
//        double sr;
//        double amin = a[0];
//        int imin = 0;
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        Console.WriteLine("минимальный элемент");
//        Console.WriteLine(amin);
//        Console.WriteLine("максимальный элемент");
//        Console.WriteLine(amax);
//        for (int i=0; i<n; i++)
//        {
//            if(imax<imin)
//            {
//                if (a[i]>0)
//                {
//                    sum = sum + a[i];
//                    m += 1;
//                }
//            }
//            else if(imax>imax)
//            {
//                if (a[i]<0)
//                {
//                    sum = sum + a[i];
//                    m += 1;
//                }
//            }
//        }
//        sr = sum / m;
//        Console.Write(sr);
//    }
//}

//18
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("введите количество элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        Console.WriteLine("введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        double amaxc = a[0];
//        int imaxc = 0;
//        double amaxn = a[0];
//        int imaxn = 0;
//        for (int i = 0; i < n; i=i+2)
//        {
//            if (a[i]>amaxc)
//            {
//                amaxc = a[i];
//                imaxc = i;
//            }
//        }
//        for (int i = 1; i < n; i = i + 2)
//        {
//            if (a[i] > amaxn)
//            {
//                amaxn = a[i];
//                imaxn = i;
//            }
//        }
//        Console.WriteLine("минимальный элемент среди четных ");
//        Console.WriteLine(amaxc);
//        Console.WriteLine("максимальный элемент среди нечетных ");
//        Console.WriteLine(amaxn);
//        for (int i = 0; i < n; i++)
//        {
//            if(amaxc>amaxn)
//            {
//                for (int h = 0; h < n/2; h++)
//                {
//                    a[h] = 0;
//                }
//            }
//            else
//            {
//                for (int l = n; l > n/2; l--)
//                {
//                    a[l] = 0;
//                }
//            }
//        }
//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}

// 19
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("введите кол-во элементов массива ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        Console.WriteLine("введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        double sum = 0;
//        int m = 0;
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//            sum=sum+ a[i];
//        }
//        Console.WriteLine("сумма");
//        Console.WriteLine(sum);
//        Console.WriteLine("максимальный элемент");
//        Console.WriteLine(amax);
//        for (int i = 0; i < n; i++)
//        {
//            if (amax>sum)
//            {
//                a[imax] = 0;
//            }
//            else
//            {
//                a[imax] = amax * amax;
//            }
//        }
//        Console.WriteLine("");
//        for (int i=0; i<n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}

// 20
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("введите количество элементов массива ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        Console.WriteLine("введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        double amin = a[0];
//        int imin = 0;
//        int ineg = 0;
//        double sum = 0;
//        double neg = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("минимальный элемент");
//        Console.WriteLine(amin);
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < 0)
//            {
//                neg = a[i];
//                ineg = i;
//                break;
//            }
//        }
//        Console.WriteLine("первый отрицательный элемент");
//        Console.WriteLine(neg);
//        for (int i = 0; i < n; i++)
//        {
//            if (ineg < imin)
//            {
//                sum = sum + a[i];
//                i = i + 1;
//            }
//            else
//            {
//                i = i + 1;
//                sum = sum + a[i];

//            }
//        }
//        Console.WriteLine("сумма элементов");
//        Console.WriteLine(sum);
//    }
//}
////3 уровень
//1
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[] array = { 1, 3, 2, 5, 4, 3, 6, 3 };
//        int max = array[0];
//        int maxCount = 1;      
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > max)
//            {
//                max = array[i];
//                maxCount = 1;
//            }
//            else if (array[i] == max)
//            {
//                maxCount++;
//            }
//        }
//        int[] indexes = new int[maxCount];
//        int index = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] == max)
//            {
//                indexes[index] = i;
//                index++;
//            }
//        }
//        Console.WriteLine("индексы максимальных элементов: ");
//        for (int i = 0; i < indexes.Length; i++)
//        {
//            Console.Write(indexes[i] + " ");
//        }
//        Console.ReadLine();
//    }
//}
//
//2
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите количество элементов массива: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("введите массив: ");
//        int[] a = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            a[i] = int.Parse(s);
//        }
//        int amax = a[0];
//        int imax = 0;
//        int m = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//            }
//        }
//        for (int i = 0;i < n; i++)
//        {
//            if (a[i] == amax)
//            {
//                m++;
//                a[i] += m;  
//            }
//        }
//        Console.WriteLine("полученный массив: ");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}
//
//3
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("введите количество элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        Console.WriteLine("введите массив ");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        double r = 0;
//        for (int i = 1; i < imax; i = i + 2)
//        {
//            r = a[i];
//            a[i] = a[i - 1];
//            a[i - 1] = r;
//        }
//        Console.WriteLine("полученный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}