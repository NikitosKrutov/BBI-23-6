using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using Internal;
using ProtoBuf;

//1.5

[JsonDerivedType(typeof(ComputerScienceStudent), typeDiscriminator: "Computer science student")]
[JsonDerivedType(typeof(MathStudent), typeDiscriminator: "Math student")]
[XmlInclude(typeof(ComputerScienceStudent))]
[XmlInclude(typeof(MathStudent))]
[ProtoInclude(5, typeof(ComputerScienceStudent))]
[ProtoInclude(6, typeof(MathStudent))]
[ProtoContract]
public abstract class Student
{
    protected string Name;
    protected int Grade;
    protected int Absences;
    [ProtoMember(1)]
    public string name { get { return Name; } set { Name = value ?? string.Empty; } }
    [ProtoMember(2)]
    public int grade { get { return Grade; } set { Grade = value; } }
    [ProtoMember(3)]
    public int absences { get { return Absences; } set { Absences = value; } }


    public Student(string name, int grade, int absences)
    {
        Name = name;
        Grade = grade;
        Absences = absences;
    }
    public Student() { }

    public override string ToString()
    {
        return $"Студент: {Name}, Оценка: {Grade}, Пропущено занятий: {Absences}";
    }
}

[ProtoContract]
public class ComputerScienceStudent : Student
{
    public ComputerScienceStudent(string name, int grade, int absences) : base(name, grade, absences)
    {
    }
    public ComputerScienceStudent() : base() { }
}

[ProtoContract]
public class MathStudent : Student
{
    public MathStudent(string name, int grade, int absences) : base(name, grade, absences)
    {
    }
    public MathStudent() : base() { }
}

[JsonDerivedType(typeof(ComputerScienceLesson), typeDiscriminator: "Computer science lesson")]
[JsonDerivedType(typeof(MathLesson), typeDiscriminator: "Math lesson")]
[XmlInclude(typeof(ComputerScienceLesson))]
[XmlInclude(typeof(MathLesson))]
[ProtoInclude(7, typeof(ComputerScienceLesson))]
[ProtoInclude(8, typeof(MathLesson))]
[ProtoContract]
public abstract class Lesson
{
    protected List<Student> Students = new List<Student>();
    [ProtoMember(4)]
    public List<Student> students { get { return Students; } set { Students = value; } }

    public Lesson() { }
    public abstract void AddStudent(string name, int grade, int absences);

    public void PrintStudents()
    {
        Console.WriteLine($"Список студентов:");
        foreach (var student in Students)
        {
            Console.WriteLine(student);
        }
    }
}

[ProtoContract]
public class ComputerScienceLesson : Lesson
{
    public override void AddStudent(string name, int grade, int absences)
    {
        Students.Add(new ComputerScienceStudent(name, grade, absences));
    }
    public ComputerScienceLesson() : base() { }
}

[ProtoContract]
public class MathLesson : Lesson
{
    public override void AddStudent(string name, int grade, int absences)
    {
        Students.Add(new MathStudent(name, grade, absences));
    }
    public MathLesson() : base() { }
}

class Program
{
    static void Main(string[] args)
    {
        Lesson computerScienceLesson = new ComputerScienceLesson();
        Lesson mathLesson = new MathLesson();

        computerScienceLesson.AddStudent("Анна", 2, 3);
        computerScienceLesson.AddStudent("Иван", 2, 1);
        computerScienceLesson.AddStudent("Мария", 2, 4);
        computerScienceLesson.AddStudent("Петр", 3, 0);
        computerScienceLesson.AddStudent("Никита", 4, 2);

        mathLesson.AddStudent("Елена", 5, 2);
        mathLesson.AddStudent("Алексей", 5, 0);
        mathLesson.AddStudent("Дмитрий", 4, 1);
        mathLesson.AddStudent("Ольга", 3, 3);
        mathLesson.AddStudent("Сергей", 2, 4);

        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        path = Path.Combine(path, "9.1");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        MySerializer[] serializers = new MySerializer[3]
        {
            new MyJsonSerializer(),
            new MyXmlSerializer(),
            new MyBinarySerializer()
        };

        string[] computerScienceFiles = new string[3]
        {
            "computerScience_data.json",
            "computerScience_data.xml",
            "computerScience_data.bin"
        };

        for (int i = 0; i < serializers.Length; i++)
            serializers[i].Write(computerScienceLesson, Path.Combine(path, computerScienceFiles[i]));

        string[] mathFiles = new string[3]
        {
            "math_data.json",
            "math_data.xml",
            "math_data.bin"
        };

        for (int i = 0; i < serializers.Length; i++)
            serializers[i].Write(mathLesson, Path.Combine(path, mathFiles[i]));

        Console.WriteLine("Computer science");
        for (int i = 0; i < serializers.Length; i++)
        {
            Console.WriteLine($"From {computerScienceFiles[i]}");
            computerScienceLesson = serializers[i].Read<Lesson>(Path.Combine(path, computerScienceFiles[i]));
            computerScienceLesson.PrintStudents();
            Console.WriteLine();
        }

        Console.WriteLine("Math");
        for (int i = 0; i < serializers.Length; i++)
        {
            Console.WriteLine($"From {mathFiles[i]}");
            mathLesson = serializers[i].Read<Lesson>(Path.Combine(path, mathFiles[i]));
            mathLesson.PrintStudents();
            Console.WriteLine();
        }
    }
}

// //2.6
// [JsonDerivedType(typeof(Diving3m), typeDiscriminator: "Diving 3 meters")]
// [JsonDerivedType(typeof(Diving5m), typeDiscriminator: "Diving 5 meters")]
// [XmlInclude(typeof(Diving3m))]
// [XmlInclude(typeof(Diving5m))]
// [ProtoInclude(4, typeof(Diving3m))]
// [ProtoInclude(5, typeof(Diving5m))]
// [ProtoContract]
// public abstract class Diving
// {
//    protected string disciplineName;
//     [ProtoMember(3)]
//    public string DisciplineName { get { return disciplineName; } set { disciplineName = value; } }

//    public Diving(string name)
//    {
//        disciplineName = name;
//    }

//    public abstract void GenerateProtocol(Driver[] drivers);
// }

// [ProtoContract]
// public class Diving3m : Diving
// {
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
// }

// [ProtoContract]
// public class Diving5m : Diving
// {
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
// }

// [ProtoContract]
// public struct Driver
// {
//    private string lastName;
//    private int[] scores;

//    public Driver(string lastName, int[] scores)
//    {
//        this.lastName = lastName;
//        this.scores = scores;
//    }

//     [ProtoMember(1)]
//    public string LastName { get { return lastName; } set { lastName = value ?? string.Empty; } }
//    [ProtoMember(2)]
//    public int[] Scores { get { return scores; } set { scores = value; } }

//    public int TotalScore()
//    {
//        int total = 0;
//        foreach (int score in scores)
//        {
//            total += score;
//        }
//        return total;
//    }
// }

// class Program
// {
//    static void Main(string[] args)
//    {
//         Driver[] drivers = new Driver[]
//         {
//             new Driver("Иванов", new int[] { 8, 9 }),
//             new Driver("Петров", new int[] { 7, 8 }),
//             new Driver("Сидоров", new int[] { 9, 9 }),
//             new Driver("Козлов", new int[] { 6, 7 }),
//             new Driver("Смирнов", new int[] { 8, 8 })
//         };

//         string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
//         path = Path.Combine(path, "9.2");
//         if (!Directory.Exists(path))    
//         {
//             Directory.CreateDirectory(path);
//         }

//         MySerializer[] serializers = new MySerializer[3]
//         {
//             new MyJsonSerializer(),
//             new MyXmlSerializer(), 
//             new MyBinarySerializer()
//         };

//         string[] driversFiles = new string[3]
//         {
//             "data.json",
//             "data.xml",
//             "data.bin"
//         };

//         for (int i = 0; i < serializers.Length; i++)
//             serializers[i].Write(drivers, Path.Combine(path, driversFiles[i]));

//         for (int i = 0; i < serializers.Length; i++)
//         {   
//             Console.WriteLine($"From {driversFiles[i]}");
//             Diving3m diving3m = new Diving3m("Прыжки с 3-метровой вышки");
//             diving3m.GenerateProtocol(serializers[i].Read<Driver[]>(Path.Combine(path, driversFiles[i])));
//             Console.WriteLine();
//             Diving5m diving5m = new Diving5m("Прыжки с 5-метровой вышки");
//             diving5m.GenerateProtocol(serializers[i].Read<Driver[]>(Path.Combine(path, driversFiles[i])));
//             Console.WriteLine();
//         }
//    }
// }

// //3.3
// [JsonDerivedType(typeof(WomenTeam), typeDiscriminator: "Women team")]
// [JsonDerivedType(typeof(MenTeam), typeDiscriminator: "Men team")]
// [XmlInclude(typeof(WomenTeam))]
// [XmlInclude(typeof(MenTeam))]
// [ProtoInclude(5, typeof(WomenTeam))]
// [ProtoInclude(6, typeof(MenTeam))]
// [ProtoContract]
// public class Team
// {
//    private string Name;
//    private int[] Places;
//    [ProtoMember(1)]
//    public string name { get { return Name; } set { Name = value ?? string.Empty; } }
//    [ProtoMember(2)]
//    public int[] places { get { return Places; } set { Places = value; } }

//    public Team(string name, int[] places)
//    {
//        Name = name;
//        Places = places;
//    }
//    public Team() { }

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
// }

// [ProtoContract]
// public class WomenTeam : Team
// {
//    public WomenTeam(string name, int[] places) : base(name, places) { }
//    public WomenTeam() : base() { }
// }

// [ProtoContract]
// public class MenTeam : Team
// {
//    public MenTeam(string name, int[] places) : base(name, places) { }
//    public MenTeam() : base() { }
// }

// [ProtoContract]
// public class Competition
// {
//    private Team[] menTeams;
//    private Team[] womenTeams;
//    [ProtoMember(3)]
//    public Team[] MenTeams { get { return menTeams; } set { menTeams = value; } }
//    [ProtoMember(4)]
//    public Team[] WomenTeams { get { return womenTeams; } set { womenTeams = value; } }

//    public Competition(Team[] menTeams, Team[] womenTeams)
//    {
//        this.menTeams = menTeams;
//        this.womenTeams = womenTeams;
//    }
//    public Competition() { }

//    public void DetermineWinner()
//    {
//        Team menWinner = menTeams.OrderByDescending(team => team.CalculatePoints()).First();

//        Team womenWinner = womenTeams.OrderByDescending(team => team.CalculatePoints()).First();

//        Team overallWinner = menWinner.CalculatePoints() > womenWinner.CalculatePoints() ? menWinner : womenWinner;

//        Console.WriteLine($"Победитель соревнований - команда {overallWinner.GetName()} со счетом {overallWinner.CalculatePoints()} баллов.");
//    }
// }

// class Program
// {
//    static void Main(string[] args)
//    {
//         Team[] menTeams = new Team[]
//         {
//             new MenTeam("Мужская 1", new int[] { 1, 2, 3, 4, 5, 6 }),
//             new MenTeam("Мужская 2", new int[] { 7, 8, 9, 10, 11, 12 }),
//             new MenTeam("Мужская 3", new int[] { 13, 14, 15, 16, 17, 18 })
//         };

//         Team[] womenTeams = new Team[]
//         {
//             new WomenTeam("Женская 1", new int[] { 1, 2, 3, 4, 5, 6 }),
//             new WomenTeam("Женская 2", new int[] { 7, 8, 9, 10, 11, 12 }),
//             new WomenTeam("Женская 3", new int[] { 13, 14, 15, 16, 17, 18 })
//         };

//         Competition competition = new Competition(menTeams, womenTeams);

//         string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
//         path = Path.Combine(path, "9.3");
//         if (!Directory.Exists(path))    
//         {
//             Directory.CreateDirectory(path);
//         }

//         MySerializer[] serializers = new MySerializer[3]
//         {
//             new MyJsonSerializer(),
//             new MyXmlSerializer(), 
//             new MyBinarySerializer()
//         };

//         string[] competitionFiles = new string[3]
//         {
//             "data.json",
//             "data.xml",
//             "data.bin"
//         };

//         for (int i = 0; i < serializers.Length; i++)
//             serializers[i].Write(competition, Path.Combine(path, competitionFiles[i]));

//         for (int i = 0; i < serializers.Length; i++)
//         {   
//             Console.WriteLine($"From {competitionFiles[i]}");
//             competition = serializers[i].Read<Competition>(Path.Combine(path, competitionFiles[i]));
//             competition.DetermineWinner();
//             Console.WriteLine();
//         }
//    }
// }