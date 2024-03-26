////#1
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Run_500m> run500 = new List<Run_500m>();

//        run500.Add(new Run_500m("Иванова", "Группа 1", "Тренер Ларкова", 120));
//        run500.Add(new Run_500m("Петрова", "Группа 2", "Тренер Паркова", 110));
//        run500.Add(new Run_500m("Сидорова", "Группа 1", "Тренер Жаркова", 100));
//        run500.Add(new Run_500m("Смирнова", "Группа 3", "Тренер Маркова", 90));

//        Console.WriteLine("Результаты кросса на 500м:");
//        Console.WriteLine("Фамилия\t\t Группа \t\t Преподаватель \t\t Результат в секундах \t\t Норматив");

//        foreach (var runner in run500.OrderBy(runner => runner.Result))
//        {
//            runner.DisplayInfo();
//        }

//        int passedNorm = run500.Count(runner => runner.Result <= 100);
//        Console.WriteLine($"\nОбщее количество участниц, выполнивших норматив: {passedNorm}");

//        List<Run_100m> run100 = new List<Run_100m>();

//        run100.Add(new Run_100m("Иванова", "Группа 1", "Тренер Ларкова", 11));
//        run100.Add(new Run_100m("Петрова", "Группа 2", "Тренер Паркова", 7));
//        run100.Add(new Run_100m("Сидорова", "Группа 1", "Тренер Жаркова", 13));
//        run100.Add(new Run_100m("Смирнова", "Группа 3", "Тренер Маркова", 8));

//        Console.WriteLine("Результаты кросса на 100м:");
//        Console.WriteLine("Фамилия\t\t Группа \t\t Преподаватель \t\t Результат в секундах \t\t Норматив");

//        foreach (var runner in run100.OrderBy(runner => runner.Result))
//        {
//            runner.DisplayInfo();
//        }

//        passedNorm = run100.Count(runner => runner.Result <= 100);
//        Console.WriteLine($"\nОбщее количество участниц, выполнивших норматив: {passedNorm}");
//    }
//}

//abstract class Runner
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

//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"{Surname}\t\t{Group}\t\t{TeacherSurname}\t\t{Result}");
//    }
//}

//class Run_500m : Runner
//{
//    public Run_500m(string Surname, string Group, string TeacherSurname, double Result) : base(Surname, Group, TeacherSurname, Result)
//    {

//    }
//    public override void DisplayInfo()
//    {
//        Console.WriteLine($"{Surname}\t\t{Group}\t\t{TeacherSurname}\t\t{Result:F2}\t\t{(Result <= 100 ? "Выполнен" : "Не выполнен")}");
//    }
//}

//class Run_100m : Runner
//{
//    public Run_100m(string Surname, string Group, string TeacherSurname, double Result) : base(Surname, Group, TeacherSurname, Result)
//    {

//    }
//    public override void DisplayInfo()
//    {
//        Console.WriteLine($"{Surname}\t\t{Group}\t\t{TeacherSurname}\t\t{Result:F2}\t\t{(Result <= 10 ? "Выполнен" : "Не выполнен")}");
//    }
//}



////#2
//using System;

//class Person
//{
//    private string family;
//    public string Family { get { return family; } }


//    public Person(string family1)
//    {
//        family = family1;

//    }
//}

//class Student : Person
//{
//    private static int id;
//    private int number;
//    private double rez1, rez2, rez3, rez4;
//    private double rez;
//    private double sr(double x, double y, double z, double w)
//    {
//        return (x + y + z + w) / 4;
//    }
//    public double Rez { get { return rez; } }
//    public Student(string family, double rezz1, double rezz2, double rezz3, double rezz4) : base(family)
//    {
//        rez = 0;
//        rez1 = rezz1;
//        rez2 = rezz2;
//        rez3 = rezz3;
//        rez4 = rezz4;
//        rez = sr(rez1, rez2, rez3, rez4);
//        number = Convert.ToInt32($"2305{id}");
//        id++;
//    }
//    public void DisplayInfo()
//    {
//        Console.WriteLine("Фамилия {0}\t Номер студ билета {1}\t Средний балл {2,4:f2}", Family, number, Rez);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Student[] os = new Student[4];
//        os[0] = new Student("Умкин", 3.0, 4.0, 5.0, 4.0);
//        os[1] = new Student("Пупкин", 4.0, 5.0, 3.0, 5.0);
//        os[2] = new Student("Лупкин", 3.0, 3.0, 4.0, 5.0);
//        os[3] = new Student("Зупкин", 5.0, 5.0, 5.0, 5.0);

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
//            Student temp;
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



//#3
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Group_Student
//{
//    private static double sum;
//    private static int count;
//    public string group_name;
//    protected string surname;
//    protected double mark1, mark2, mark3, mark4;

//    public string Surname { get { return surname; } }

//    public virtual double AverageMark()
//    {
//        return (mark1 + mark2 + mark3 + mark4) / 4;
//    }

//    public Group_Student(string surname, double mark1, double mark2, double mark3, double mark4)
//    {
//        this.surname = surname;
//        this.mark1 = mark1;
//        this.mark2 = mark2;
//        this.mark3 = mark3;
//        this.mark4 = mark4;
//        group_name = "-";
//    }
//    public virtual double getAVG()
//    {
//        return Group_Student.sum / Group_Student.count;
//    }
//}

//class BBI_23_4_Student : Group_Student
//{
//    private static double sum;
//    private static int count;
//    private double math, physics;
//    public BBI_23_4_Student(string surname, double mark1, double mark2, double mark3, double mark4, double math, double physics) : base(surname, mark1, mark2, mark3, mark4)
//    {
//        this.math = math;
//        this.physics = physics;
//        sum += AverageMark();
//        count++;
//        group_name = "BBI_23_4";
//    }
//    public override double AverageMark()
//    {
//        return (mark1 + mark2 + mark3 + mark4 + math + physics) / 6;
//    }
//    public override double getAVG()
//    {
//        return BBI_23_4_Student.sum / BBI_23_4_Student.count;
//    }
//}
//class BBI_23_5_Student : Group_Student
//{
//    private static double sum;
//    private static int count;
//    private double PE, chemistry;
//    public BBI_23_5_Student(string surname, double mark1, double mark2, double mark3, double mark4, double PE, double chemistry) : base(surname, mark1, mark2, mark3, mark4)
//    {
//        this.PE = PE;
//        this.chemistry = chemistry;
//        sum += AverageMark();
//        count++;
//        group_name = "BBI-23-5";
//    }
//    public override double AverageMark()
//    {
//        return (mark1 + mark2 + mark3 + mark4 + PE + chemistry) / 6;
//    }
//    public override double getAVG()
//    {
//        return BBI_23_5_Student.sum / BBI_23_5_Student.count;
//    }
//}
//class BBI_23_6_Student : Group_Student
//{
//    private static double sum;
//    private static int count;
//    private double english, spanish;
//    public BBI_23_6_Student(string surname, double mark1, double mark2, double mark3, double mark4, double english, double spanish) : base(surname, mark1, mark2, mark3, mark4)
//    {
//        this.english = english;
//        this.spanish = spanish;
//        sum += AverageMark();
//        count++;
//        group_name = "BBI-23-6";
//    }
//    public override double AverageMark()
//    {
//        return (mark1 + mark2 + mark3 + mark4 + english + spanish) / 6;
//    }
//    public override double getAVG()
//    {
//        return BBI_23_6_Student.sum / BBI_23_6_Student.count;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Group_Student[][] groups =
//        {
//            new BBI_23_4_Student[]
//            {
//                new BBI_23_4_Student("Васильев",5.0, 5.0, 4.0, 5.0, 3.0, 4.0),
//                new BBI_23_4_Student("Иванов", 4.0, 4.0, 3.0, 4.0, 2.0, 3.0),
//                new BBI_23_4_Student("Доржиев", 5.0, 4.0, 5.0, 5.0, 4.0, 5.0)
//            },
//            new BBI_23_5_Student[]
//            {
//                new BBI_23_5_Student("Цоктоев", 5.0, 4.0, 3.0, 5.0, 5.0, 4.0),
//                new BBI_23_5_Student("Гатапов", 4.0, 3.0, 2.0, 3.0, 3.0, 4.0),
//                new BBI_23_5_Student("Лыпкин", 5.0, 4.0, 3.0, 3.0, 3.0, 5.0)
//            },
//            new BBI_23_6_Student[]
//            {
//                new BBI_23_6_Student("Харханов", 5.0, 5.0, 5.0, 5.0, 5.0, 5.0),
//                new BBI_23_6_Student("Жамсоев", 4.0, 4.0, 4.0, 4.0, 4.0, 3.0),
//                new BBI_23_6_Student("Игумнов", 4.0, 5.0, 5.0, 3.0, 4.0, 5.0)
//            }
//        };

//        Dictionary<string, double> averages = new Dictionary<string, double>();
//        for (int i = 0; i < groups.GetLength(0); i++)
//        {
//            averages.Add(groups[i][0].group_name, groups[i][0].getAVG());
//        }

//        var sortedAverages = averages.OrderByDescending(x => x.Value);

//        Console.WriteLine("Group");
//        foreach (var item in sortedAverages)
//        {
//            Console.WriteLine($"{item.Key}\t\t{item.Value:F2}");
//        }
//    }
//}