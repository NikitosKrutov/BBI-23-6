using System;
using System.Linq;

//1.5
//struct Student
//{
//    public string Name;
//    public int Grade;
//    public int Absences;

//    public Student(string name, int grade, int absences)
//    {
//        Name = name;
//        Grade = grade;
//        Absences = absences;
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

//        for (int i = 0; i < students.Length - 1; i++)
//        {
//            for (int j = 0; j < students.Length - 1 - i; j++)
//            {
//                if (students[j].Grade == 2 && students[j].Absences < students[j + 1].Absences)
//                {
//                    Student temp = students[j];
//                    students[j] = students[j + 1];
//                    students[j + 1] = temp;
//                }
//            }
//        }

//        Console.WriteLine("Список неуспевающих студентов в порядке убывания количества пропущенных занятий:");
//        foreach (var student in students)
//        {
//            if (student.Grade == 2)
//            {
//                Console.WriteLine($"{student.Name}: Оценка - {student.Grade}, Пропущено занятий - {student.Absences}");
//            }
//        }
//    }
//}


//2.6
//struct Diver
//{
//    public string LastName;
//    public int[] Scores;

//    public Diver(string lastName, int[] scores)
//    {
//        LastName = lastName;
//        Scores = scores;
//    }

//    public int TotalScore()
//    {
//        int total = 0;
//        foreach (int score in Scores)
//        {
//            total += score;
//        }
//        return total;
//    }
//}

//class CompetitionProtocol
//{
//    private Diver[] divers;

//    public CompetitionProtocol(Diver[] divers)
//    {
//        this.divers = divers;
//    }

//    public void GenerateProtocol()
//    {
//        for (int i = 0; i < divers.Length - 1; i++)
//        {
//            for (int j = 0; j < divers.Length - 1 - i; j++)
//            {
//                if (divers[j].TotalScore() < divers[j + 1].TotalScore())
//                {
//                    Diver temp = divers[j];
//                    divers[j] = divers[j + 1];
//                    divers[j + 1] = temp;
//                }
//            }
//        }
//        Console.WriteLine("Итоговый протокол соревнований:");
//        for (int i = 0; i < divers.Length; i++)
//        {
//            Console.WriteLine($"{i + 1}. {divers[i].LastName}: {divers[i].TotalScore()} баллов");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Diver[] divers = new Diver[]
//        {
//            new Diver("Иванов", new int[] { 8, 9 }),
//            new Diver("Петров", new int[] { 7, 7 }),
//            new Diver("Сидоров", new int[] { 9, 8 }),
//            new Diver("Козлов", new int[] { 6, 5 }),
//            new Diver("Смирнов", new int[] { 8, 6 })
//        };
//        CompetitionProtocol protocol = new CompetitionProtocol(divers);

//        protocol.GenerateProtocol();
//    }
//}


//3.3
//struct Team
//{
//    public string Name;
//    public int[] Places;

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

//        Competition competition = new Competition(teams);
//        competition.DetermineWinner();
//    }
//}

