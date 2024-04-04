using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Run_500m> run500 = new List<Run_500m>();

        run500.Add(new Run_500m("Иванова", "Группа 1", "Тренер Ларкова", 120));
        run500.Add(new Run_500m("Петрова", "Группа 2", "Тренер Паркова", 110));
        run500.Add(new Run_500m("Сидорова", "Группа 1", "Тренер Жаркова", 100));
        run500.Add(new Run_500m("Смирнова", "Группа 3", "Тренер Маркова", 90));

        Console.WriteLine("Результаты кросса на 500м:");
        Console.WriteLine("Фамилия\t\t Группа\t\t Преподаватель\t\t Результат в секундах\t\t Норматив");

        QuickSort(run500, 0, run500.Count - 1);

        foreach (var runner in run500)
        {
            runner.DisplayInfo();
        }

        int passedNorm = run500.Count(runner => runner.Result <= 100);
        Console.WriteLine($"\nОбщее количество участниц, выполнивших норматив: {passedNorm}");

        List<Run_100m> run100 = new List<Run_100m>();

        run100.Add(new Run_100m("Иванова", "Группа 1", "Тренер Ларкова", 11));
        run100.Add(new Run_100m("Петрова", "Группа 2", "Тренер Паркова", 7));
        run100.Add(new Run_100m("Сидорова", "Группа 1", "Тренер Жаркова", 13));
        run100.Add(new Run_100m("Смирнова", "Группа 3", "Тренер Маркова", 8));

        Console.WriteLine("Результаты кросса на 100м:");
        Console.WriteLine("Фамилия\t\t Группа\t\t Преподаватель\t\t Результат в секундах\t\t Норматив");

        QuickSort(run100, 0, run100.Count - 1);

        foreach (var runner in run100)
        {
            runner.DisplayInfo();
        }

        passedNorm = run100.Count(runner => runner.Result <= 10);
        Console.WriteLine($"\nОбщее количество участниц, выполнивших норматив: {passedNorm}");
    }

    static void QuickSort<T>(List<T> list, int left, int right) where T : Runner
    {
        if (left < right)
        {
            int pivot = Partition(list, left, right);
            QuickSort(list, left, pivot - 1);
            QuickSort(list, pivot + 1, right);
        }
    }

    static int Partition<T>(List<T> list, int left, int right) where T : Runner
    {
        T pivotValue = list[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (list[j].Result < pivotValue.Result)
            {
                i++;
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }

        T temp2 = list[i + 1];
        list[i + 1] = list[right];
        list[right] = temp2;

        return i + 1;
    }
}

abstract class Runner
{
    public string Surname { get; private set; }
    public string Group { get; private set; }
    public string TeacherSurname { get; private set; }
    public double Result { get; private set; }

    public Runner(string surname, string group, string teacherSurname, double result)
    {
        Surname = surname;
        Group = group;
        TeacherSurname = teacherSurname;
        Result = result;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"{Surname}\t\t{Group}\t\t{TeacherSurname}\t\t{Result:F2}\t\t{(Result <= 100 ? "Выполнен" : "Не выполнен")}");
    }
}

class Run_500m : Runner
{
    public Run_500m(string surname, string group, string teacherSurname, double result) : base(surname, group, teacherSurname, result)
    {
    }
}

class Run_100m : Runner
{
    public Run_100m(string surname, string group, string teacherSurname, double result) : base(surname, group, teacherSurname, result)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{Surname}\t\t{Group}\t\t{TeacherSurname}\t\t{Result:F2}\t\t{(Result <= 10 ? "Выполнен" : "Не выполнен")}");
    }
}
