using System;
abstract class Profession
{
    private string name;
    protected string professionName;
    public string Name { get { return name; } }
    private int nadbavka;
    public int Nadbavka { get { return nadbavka; } }
    public Profession(string name, int nadbavka)
    {
        this.name = name;
        this.nadbavka = nadbavka;
    }
    public void PrintInfo()
    {
        Console.WriteLine("{0} {1}, зарплата: {2}", professionName, name, Calculate());
    }
    public abstract int Calculate();
}
class Fireman : Profession
{
    private int dangerous;
    public int Dangerous { get { return dangerous; } }
    public Fireman(string name, int nadbavka, int dangerous) : base(name, nadbavka)
    {
        professionName = "fireman";
        this.dangerous = dangerous;
    }
    public override int Calculate()
    {
        return (dangerous + Nadbavka) * 100;
    }
}
class Engineer : Profession
{
    private int category;
    public int Category { get { return category; } }
    public Engineer(string name, int category, int nadbavka) : base(name, nadbavka)
    {
        professionName = "engineer";
        this.category = category;
    }
    public override int Calculate()
    {
        return (Nadbavka + category) * 100;
    }
}
class Scientist : Profession
{
    private int degree;
    public int Degree { get { return degree; } }
    public Scientist(string name, int degree, int nadbavka) : base(name, nadbavka)
    {
        professionName = "scientist";
        this.degree = degree;
    }
    public override int Calculate()
    {
        return (Nadbavka + degree) * 100;
    }
}
class Programm
{
    static void Main(string[] args)
    {
        Profession[] firemen = new Profession[5]
        {
            new Fireman("Алексей", 4, 2),
            new Fireman("Борис", 8, 1),
            new Fireman("Игорь", 5, 2),
            new Fireman("Виктор", 6, 3),
            new Fireman("Юрий", 3, 1)
        };
        SortBySalary(firemen);
        Print(firemen);
        Profession[] engineers = new Profession[]
        {
            new Engineer("Нина", 3, 5),
            new Engineer("Инна", 3, 1),
            new Engineer("Мария", 4, 3),
            new Engineer("Василий", 2, 1),
            new Engineer("Эдуард", 5, 4)
        };
        SortBySalary(engineers);
        Print(engineers);
        Profession[] scientists = new Profession[]
        {
            new Scientist("Надежда", 1, 8),
            new Scientist("Арсений", 3, 5),
            new Scientist("Артемий", 3, 7),
            new Scientist("Джейсон", 2, 5),
            new Scientist("Макар", 4, 5)
        };
        SortBySalary(scientists);
        Print(scientists);
        Profession[] professions = new Profession[15];
        for (int i = 0; i < 5; i++)
        {
            professions[i] = firemen[i];
        }
        for (int i = 0; i < 5; i++)
        {
            professions[i + 5] = engineers[i];
        }
        for (int i = 0; i < 5; i++)
        {
            professions[i + 10] = scientists[i];
        }
        SortBySalary(professions);
        Print(professions);
        Console.ReadKey();
    }
    static void SortBySalary(Profession[] professions)
    {
        Profession t;
        for (int i = 0; i < professions.Length; i++)
        {
            for (int j = 0; j < professions.Length - 1; j++)
            {
                if (professions[j].Calculate() < professions[j + 1].Calculate())
                {
                    t = professions[j];
                    professions[j] = professions[j + 1];
                    professions[j + 1] = t;
                }
            }
        }
    }
    static void Print(Profession[] professions)
    {
        for (int i = 0; i < professions.Length; i++)
        {
            professions[i].PrintInfo();
        }
        Console.WriteLine();
    }
}