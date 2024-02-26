//level 2 n1 добавила метод DisplayInfo() в структуре для вывода информации о студенте
//using System;

//struct Students
//{
//    private string family;
//    private double rez1, rez2, rez3, rez4;
//    private double rez;
//    public double Rez { get { return rez; } }
//    public string Family { get { return family; } }
//    private double sr(double x, double y, double z, double w)
//    {
//        return (x + y + z + w) / 4;
//    }

//    public void DisplayInfo()
//    {
//        Console.WriteLine("Фамилия {0}\t  Средний балл {1,4:f2}", Family, Rez);
//    }

//    public Students(string family1, double rezz1, double rezz2, double rezz3, double rezz4)
//    {
//        family = family1;
//        rez = 0;
//        rez1 = rezz1;
//        rez2 = rezz2;
//        rez3 = rezz3;
//        rez4 = rezz4;
//        rez = sr(rez1, rez2, rez3, rez4);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Students[] os = new Students[4];
//        os[0] = new Students("Умкин", 3.0, 4.0, 5.0, 4.0);
//        os[1] = new Students("Пупкин", 4.0, 5.0, 3.0, 5.0);
//        os[2] = new Students("Лупкин", 3.0, 3.0, 4.0, 5.0);
//        os[3] = new Students("Зупкин", 5.0, 5.0, 5.0, 5.0);

//        foreach (var student in os)
//        {
//            student.DisplayInfo();
//        }

//        for (int i = 0; i < os.Length - 1; i++)
//        {
//            double amax = os[i].Rez;
//            int imax = i;
//            for (int j = i + 1; j < os.Length; j++)
//            {
//                if (os[j].Rez > amax)
//                {
//                    amax = os[j].Rez;
//                    imax = j;
//                }
//            }
//            Students temp;
//            temp = os[imax];
//            os[imax] = os[i];
//            os[i] = temp;
//        }

//        Console.WriteLine();

//        foreach (var student in os)
//        {
//            if (student.Rez >= 4)
//            {
//                student.DisplayInfo();
//            }
//        }
//    }
//}




//level 1 n2
//1)добавила метод DisplayInfo() в структуре для вывода информации о студенте
//2)если я правильно поняла то поля поля теперь в приватном set
//
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Runner> runners = new List<Runner>();

//        runners.Add(new Runner("Иванова", "Группа 1", "Тренер Ларкова", 12));
//        runners.Add(new Runner("Петрова", "Группа 2", "Тренер Паркова", 11));
//        runners.Add(new Runner("Сидорова", "Группа 1", "Тренер Жаркова", 10));
//        runners.Add(new Runner("Смирнова", "Группа 3", "Тренер Маркова", 9));

//        Console.WriteLine("Результаты кросса:");
//        Console.WriteLine("Фамилия\t\t Группа \t\t Преподаватель \t\t Результат в секундах \t\t Норматив");

//        foreach (var runner in runners.OrderBy(runner => runner.Result))
//        {
//            runner.DisplayInfo();
//        }

//        int passedNorm = runners.Count(runner => runner.Result <= 10);
//        Console.WriteLine($"\nОбщее количество участниц, выполнивших норматив: {passedNorm}");
//    }
//}

//class Runner
//{
//    public string Surname { get; private set; }
//    public string Group { get; private set; }
//    public string TeacherSurname { get; private set; }
//    public double Result { get; private set; }

//    public Runner(string surname, string group, string teacherSurname, double result)
//    {
//        Surname = surname;
//        Group = group;
//        TeacherSurname = teacherSurname;
//        Result = result;
//    }

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"{Surname}\t\t{Group}\t\t{TeacherSurname}\t\t{Result:F2}\t\t{(Result <= 10 ? "Выполнен" : "Не выполнен")}");
//    }
//}


