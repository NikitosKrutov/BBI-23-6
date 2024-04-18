using System;
using System.Linq;

//1.5
//struct Student
//{
//    private string Name;
//    public int Grade { get; private set; }
//    public int Absences { get; private set; }

//    public Student(string name, int grade, int absences)
//    {
//        Name = name;
//        Grade = grade;
//        Absences = absences;
//    }

//    public string ToString()
//    {
//        return $"Студент: {Name}, Оценка: {Grade}, Пропущено занятий: {Absences}";
//    }

//    public void PrintInfo()
//    {
//        Console.WriteLine(ToString());
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Student[] students = new Student[]
//        {
//            new Student("Анна", 2, 3),
//            new Student("Иван", 2, 1),
//            new Student("Мария", 2, 4),
//            new Student("Петр", 3, 0),
//            new Student("Елена", 2, 2),
//            new Student("Алексей", 5, 0)
//        };

//        var failingStudents = students
//            .Where(student => student.Grade == 2)
//            .OrderByDescending(student => student.Absences);

//        Console.WriteLine("Список неуспевающих студентов в порядке убывания количества пропущенных занятий:");
//        foreach (var student in failingStudents)
//        {
//            student.PrintInfo();
//        }
//    }
//}


//2.6
//struct Driver
//{
//    public string LastName { get; private set; }
//    private int[] Scores;
//    private int totalScore;

//    public Driver(string lastName, int[] scores)
//    {
//        LastName = lastName;
//        Scores = scores;
//        totalScore = -1;
//        TotalScore();
//    }

//    public int TotalScore()
//    {
//        if (totalScore == -1)
//        {
//            totalScore = 0;
//            foreach (int score in Scores)
//            {
//                totalScore += score;
//            }
//        }
//        return totalScore;
//    }

//    public void PrintInfo()
//    {
//        Console.WriteLine($"Фамилия: {LastName}, Результаты: [{string.Join(", ", Scores)}]");
//    }

//    public static Driver Winner(Driver[] drivers)
//    {
//        Driver winner = drivers[0];
//        int maxTotalScore = winner.TotalScore();
//        for (int i = 1; i < drivers.Length; i++)
//        {
//            int curTotalScore = drivers[i].totalScore;
//            if (curTotalScore > maxTotalScore)
//            {
//                winner = drivers[i];
//                maxTotalScore = curTotalScore;
//            }
//        }
//        return winner;
//    }
//}

//class CompetitionProtocol
//{
//    private Driver[] drivers;

//    public CompetitionProtocol(Driver[] drivers)
//    {
//        this.drivers = drivers;
//    }

//    public void GenerateProtocol()
//    {
//        foreach (var driver in drivers)
//        {
//            driver.PrintInfo();
//        }

//        Driver winner = Driver.Winner(drivers);
//        Console.WriteLine($"Победитель - {winner.LastName} с общим результатом {winner.TotalScore()} баллов.");
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

//        CompetitionProtocol protocol = new CompetitionProtocol(drivers);
//        protocol.GenerateProtocol();
//    }
//}


//3.3
//struct Team
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
//        for (int i = 0; i < Places.Length && i < pointsByPlace.Length; i++)
//        {
//            points += pointsByPlace[i];
//        }
//        return points;
//    }

//    public void PrintInfo()
//    {
//        Console.WriteLine($"Команда {Name} имеет результаты: [{string.Join(", ", Places)}]");
//    }
//}

//class Competition
//{
//    private Team[] teams;

//    public Competition(Team[] teams)
//    {
//        this.teams = teams;
//    }

//    public void DetermineWinner()
//    {
//        Team winner = teams.OrderByDescending(team => team.CalculatePoints()).First();
//        Console.WriteLine($"Победитель соревнований - команда {winner.Name} со счетом {winner.CalculatePoints()} баллов.");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Team[] teams = new Team[]
//        {
//            new Team("Команда 1", new int[] { 1, 2, 3, 4, 5, 6 }),
//            new Team("Команда 2", new int[] { 7, 8, 9, 10, 11, 12 }),
//            new Team("Команда 3", new int[] { 13, 14, 15, 16, 17, 18 })
//        };

//        foreach (var team in teams)
//        {
//            team.PrintInfo();
//        }

//        Competition competition = new Competition(teams);
//        competition.DetermineWinner();
//    }
//}

