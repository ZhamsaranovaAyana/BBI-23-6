//попытка 1 Жамсараанова А - 7ая по списку
//level 1 n2
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
//            Console.WriteLine($"{runner.Surname}\t\t{runner.Group}\t\t{runner.TeacherSurname}\t\t{runner.Result:F2}\t\t{(runner.Result <= 10 ? "Выполнен" : "Не выполнен")}");
//        }

   
//        int passedNorm = runners.Count(runner => runner.Result <= 10);
//        Console.WriteLine($"\nОбщее количество участниц, выполнивших норматив: {passedNorm}");
//    }
//}

//class Runner
//{
//    public string Surname { get; set; }
//    public string Group { get; set; }
//    public string TeacherSurname { get; set; }
//    public double Result { get; set; }

//    public Runner(string surname, string group, string teacherSurname, double result)
//    {
//        Surname = surname;
//        Group = group;
//        TeacherSurname = teacherSurname;
//        Result = result;
//    }
//}
//
////level 2  n1
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
//        for (int i = 0; i < os.Length; i++)
//        {
//            Console.WriteLine("Фамилия {0}\t  Средний балл {1,4:f2}", os[i].Family, os[i].Rez);
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
//        for (int i = 0; i < os.Length; i++)
//        {
//            if (os[i].Rez >= 4)
//            {
//                Console.WriteLine("Фамилия {0}\t  Средний балл {1,4:f2}", os[i].Family, os[i].Rez);
//            }
//        }
//    }
//}
//level 3 n1
//using System;
//using System.Collections.Generic;

//class Student
//{
//    private string surname;
//    private double mark1, mark2, mark3, mark4, mark5;
//    private double averageMark;

//    public string Surname { get { return surname; } }
//    public double AverageMark { get { return averageMark; } }

//    private double CalculateAverageMark(double mark1, double mark2, double mark3, double mark4, double mark5)
//    {
//        return (mark1 + mark2 + mark3 + mark4 + mark5) / 5;
//    }

//    public Student(string surname, double mark1, double mark2, double mark3, double mark4, double mark5)
//    {
//        this.surname = surname;
//        this.mark1 = mark1;
//        this.mark2 = mark2;
//        this.mark3 = mark3;
//        this.mark4 = mark4;
//        this.mark5 = mark5;
//        this.averageMark = CalculateAverageMark(mark1, mark2, mark3, mark4, mark5);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Student[]> groups = new List<Student[]>
//        {
//            new Student[]
//            {
//                new Student("Васильев",5.0, 5.0, 4.0, 5.0, 3.0),
//                new Student("Иванов", 4.0, 4.0, 3.0, 4.0, 2.0),
//                new Student("Доржиев", 5.0, 4.0, 5.0, 5.0, 4.0)
//            },
//            new Student[]
//            {
//                new Student("Цоктоев", 5.0, 4.0, 3.0, 5.0, 5.0),
//                new Student("Гатапов", 4.0, 3.0, 2.0, 3.0, 3.0),
//                new Student("Лыпкин", 5.0, 4.0, 3.0, 3.0, 3.0)
//            },
//            new Student[]
//            {

//                new Student("Харханов", 5.0, 5.0, 5.0, 5.0, 5.0),
//                new Student("Жамсоев", 4.0, 4.0, 4.0, 4.0, 4.0),
//                new Student("Игумнов", 4.0, 5.0, 5.0, 3.0, 4.0)
//            }
//        };

//        Dictionary<string, double> averages = new Dictionary<string, double>();

//        foreach (var group in groups)
//        {
//            double sum = 0;
//            foreach (Student student in group)
//            {
//                sum += student.AverageMark;
//            }
//            double avg = sum / group.Length;
//            averages.Add(group[0].Surname, avg);
//        }

//        var sortedAverages = averages.OrderByDescending(x => x.Value);

//        Console.WriteLine("Group");
//        foreach (var item in sortedAverages)
//        {
//            Console.WriteLine($"{item.Key}\t\t{item.Value:F2}");
//        }
//    }
//}