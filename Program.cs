

//level 2 n 1

using System;
struct Students
{
    private string family;//определение приватных полей структуры 
    private double rez1, rez2, rez3, rez4;
    private double rez;
    public double Rez { get { return rez; } }//определение свойства rez, которое возвращает значение поля rez.
    public string Family { get { return family; } }//определение свойства family, которое возвращает значение поля family.
    private double sr(double x, double y, double z, double w)//объявление приватного метода sr для вычисления среднего значения четырех чисел.

    {
        return (x + y + z + w) / 4;
    }

    public void DisplayInfo()//объявление метода displayinfo, который выводит информацию о студенте в консоль.
    {
        Console.WriteLine("Фамилия {0}\t  Средний балл {1,4:f2}", Family, Rez);
    }

    public Students(string family1, double rezz1, double rezz2, double rezz3, double rezz4)//конструктор структуры students, который инициализирует поля структуры и вычисляет средний балл
    {
        family = family1;
        rez = 0;
        rez1 = rezz1;
        rez2 = rezz2;
        rez3 = rezz3;
        rez4 = rezz4;
        rez = sr(rez1, rez2, rez3, rez4);
    }
}

class Program//Объявление класса Program с методом Main, который является точкой входа в программу.
{
    static void Main(string[] args)
    {
        Students[] os = new Students[4];//создание массива os из 4 объектов структуры students.

        os[0] = new Students("Умкин", 3.0, 4.0, 5.0, 4.0);
        os[1] = new Students("Пупкин", 4.0, 5.0, 3.0, 5.0);
        os[2] = new Students("Лупкин", 3.0, 3.0, 4.0, 5.0);
        os[3] = new Students("Зупкин", 5.0, 5.0, 5.0, 5.0);

        foreach (var student in os)// Использование цикла foreach для вывода информации о студентах в консоль с помощью метода displayinfo.
        {
            student.DisplayInfo();
        }
        for (int i = 1; i < os.Length; i++)// создаем цикл, который перебирает каждый элемент массива os
        {
            Students key = os[i];//фиксируем элемент массива os[i] в переменной key
            int j = i - 1;// переменной j значением на один меньше i
            while (j >= 0 && os[j].Rez < key.Rez)//цикл while двигает элементы массива, находящиеся слева от key, если они больше key
            {
                os[j + 1] = os[j];//сдвигает элемент вправо, увеличивая его индекс на 1
                j = j - 1;//уменьшение индекса j для проверки предыдущего элемента
            }
            os[j + 1] = key;//нашли место для key в новой части массива, поэтому теперь записываем key в свободное место в массиве
        }
        Console.WriteLine();

        foreach (var student in os)//Повторный вывод информации о студентах, чей средний балл не менее 4.
        {
            if (student.Rez >= 4)
            {
                student.DisplayInfo();
            }
        }
    }
}


