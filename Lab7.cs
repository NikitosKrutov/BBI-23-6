using System;
using System.Collections.Generic;
using System.Linq;

//1.5
//abstract class Student
//{
//    private string Name { get; }
//    private int Grade { get; }
//    private int Absences { get; }

//    protected Student(string name, int grade, int absences)
//    {
//        Name = name;
//        Grade = grade;
//        Absences = absences;
//    }

//    public override string ToString()
//    {
//        return $"Студент: {Name}, Оценка: {Grade}, Пропущено занятий: {Absences}";
//    }
//}

//class ComputerScienceStudent : Student
//{
//    public ComputerScienceStudent(string name, int grade, int absences) : base(name, grade, absences)
//    {
//    }
//}

//class MathStudent : Student
//{
//    public MathStudent(string name, int grade, int absences) : base(name, grade, absences)
//    {
//    }
//}

//abstract class Lesson
//{
//    protected List<Student> Students { get; } = new List<Student>();

//    public abstract void AddStudent(string name, int grade, int absences);

//    public void PrintStudents()
//    {
//        Console.WriteLine($"Список студентов:");
//        foreach (var student in Students)
//        {
//            Console.WriteLine(student);
//        }
//    }
//}

//class ComputerScienceLesson : Lesson
//{
//    public override void AddStudent(string name, int grade, int absences)
//    {
//        Students.Add(new ComputerScienceStudent(name, grade, absences));
//    }
//}

//class MathLesson : Lesson
//{
//    public override void AddStudent(string name, int grade, int absences)
//    {
//        Students.Add(new MathStudent(name, grade, absences));
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Lesson computerScienceLesson = new ComputerScienceLesson();
//        Lesson mathLesson = new MathLesson();

//        computerScienceLesson.AddStudent("Анна", 2, 3);
//        computerScienceLesson.AddStudent("Иван", 2, 1);
//        computerScienceLesson.AddStudent("Мария", 2, 4);
//        computerScienceLesson.AddStudent("Петр", 3, 0);

//        mathLesson.AddStudent("Елена", 5, 2);
//        mathLesson.AddStudent("Алексей", 5, 0);
//        mathLesson.AddStudent("Дмитрий", 4, 1);
//        mathLesson.AddStudent("Ольга", 3, 3);

//        computerScienceLesson.PrintStudents();

//        Console.WriteLine();

//        mathLesson.PrintStudents();
//    }
//}

//2.6
//abstract class Diving
//{
//    protected string disciplineName;

//    public Diving(string name)
//    {
//        disciplineName = name;
//    }

//    public abstract void GenerateProtocol(Driver[] drivers);
//}

//class Diving3m : Diving
//{
//    public Diving3m(string name) : base(name) { }

//    public override void GenerateProtocol(Driver[] drivers)
//    {
//        Console.WriteLine($"Протокол соревнований по {disciplineName}:");

//        foreach (var driver in drivers)
//        {
//            Console.WriteLine($"Фамилия: {driver.LastName}, Результаты: [{string.Join(", ", driver.Scores)}]");
//        }

//        Driver winner = drivers.OrderByDescending(d => d.TotalScore()).First();
//        Console.WriteLine($"Победитель - {winner.LastName} с общим результатом {winner.TotalScore()} баллов.");
//    }
//}

//class Diving5m : Diving
//{
//    public Diving5m(string name) : base(name) { }

//    public override void GenerateProtocol(Driver[] drivers)
//    {
//        Console.WriteLine($"Протокол соревнований по {disciplineName}:");

//        foreach (var driver in drivers)
//        {
//            Console.WriteLine($"Фамилия: {driver.LastName}, Результаты: [{string.Join(", ", driver.Scores)}]");
//        }

//        Driver winner = drivers.OrderByDescending(d => d.TotalScore()).First();
//        Console.WriteLine($"Победитель - {winner.LastName} с общим результатом {winner.TotalScore()} баллов.");
//    }
//}

//struct Driver
//{
//    private string lastName;
//    private int[] scores;

//    public Driver(string lastName, int[] scores)
//    {
//        this.lastName = lastName;
//        this.scores = scores;
//    }

//    public string LastName { get { return lastName; } }
//    public int[] Scores { get { return scores; } }

//    public int TotalScore()
//    {
//        int total = 0;
//        foreach (int score in scores)
//        {
//            total += score;
//        }
//        return total;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Driver[] drivers = new Driver[]
//        {
//            new Driver("Иванов", new int[] { 8, 9 }),
//            new Driver("Петров", new int[] { 7, 8 }),
//            new Driver("Сидоров", new int[] { 9, 9 }),
//            new Driver("Козлов", new int[] { 6, 7 }),
//            new Driver("Смирнов", new int[] { 8, 8 })
//        };

//        Diving3m diving3m = new Diving3m("Прыжки с 3-метровой вышки");
//        diving3m.GenerateProtocol(drivers);

//        Diving5m diving5m = new Diving5m("Прыжки с 5-метровой вышки");
//        diving5m.GenerateProtocol(drivers);
//    }
//}

//3.3
//class Team
//{
//    private string Name;
//    private int[] Places;

//    public Team(string name, int[] places)
//    {
//        Name = name;
//        Places = places;
//    }

//    public int CalculatePoints()
//    {
//        int points = 0;
//        int[] pointsByPlace = { 5, 4, 3, 2, 1 };

//        foreach (var place in Places)
//        {
//            if (place <= pointsByPlace.Length)
//                points += pointsByPlace[place - 1];
//        }

//        return points;
//    }

//    public void PrintInfo()
//    {
//        Console.WriteLine($"Команда {Name} имеет результаты: [{string.Join(", ", Places)}]");
//    }

//    public string GetName()
//    {
//        return Name;
//    }
//}

//class WomenTeam : Team
//{
//    public WomenTeam(string name, int[] places) : base(name, places) { }
//}

//class MenTeam : Team
//{
//    public MenTeam(string name, int[] places) : base(name, places) { }
//}

//class Competition
//{
//    private Team[] menTeams;
//    private Team[] womenTeams;

//    public Competition(Team[] menTeams, Team[] womenTeams)
//    {
//        this.menTeams = menTeams;
//        this.womenTeams = womenTeams;
//    }

//    public void DetermineWinner()
//    {
//        Team menWinner = menTeams.OrderByDescending(team => team.CalculatePoints()).First();

//        Team womenWinner = womenTeams.OrderByDescending(team => team.CalculatePoints()).First();

//        Team overallWinner = menWinner.CalculatePoints() > womenWinner.CalculatePoints() ? menWinner : womenWinner;

//        Console.WriteLine($"Победитель соревнований - команда {overallWinner.GetName()} со счетом {overallWinner.CalculatePoints()} баллов.");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Team[] menTeams = new Team[]
//        {
//            new MenTeam("Мужская 1", new int[] { 1, 2, 3, 4, 5, 6 }),
//            new MenTeam("Мужская 2", new int[] { 7, 8, 9, 10, 11, 12 }),
//            new MenTeam("Мужская 3", new int[] { 13, 14, 15, 16, 17, 18 })
//        };

//        Team[] womenTeams = new Team[]
//        {
//            new WomenTeam("Женская 1", new int[] { 1, 2, 3, 4, 5, 6 }),
//            new WomenTeam("Женская 2", new int[] { 7, 8, 9, 10, 11, 12 }),
//            new WomenTeam("Женская 3", new int[] { 13, 14, 15, 16, 17, 18 })
//        };

//        Competition competition = new Competition(menTeams, womenTeams);
//        competition.DetermineWinner();
//    }
//}
