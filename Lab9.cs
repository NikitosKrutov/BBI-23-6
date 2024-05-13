using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using ProtoBuf;

//1.5
[Serializable]
class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public int Absences { get; set; }
}

abstract class Lesson
{
    protected List<Student> Students { get; } = new List<Student>();

    public abstract void AddStudent(string name, int grade, int absences);

    public List<Student> GetStudents()
    {
        return Students;
    }
}

class ComputerScienceLesson : Lesson
{
    public override void AddStudent(string name, int grade, int absences)
    {
        Students.Add(new Student { Name = name, Grade = grade, Absences = absences });
    }
}

class MathLesson : Lesson
{
    public override void AddStudent(string name, int grade, int absences)
    {
        Students.Add(new Student { Name = name, Grade = grade, Absences = absences });
    }
}

class LessonSerializer
{
    public void SerializeToJson<T>(List<T> students, string filePath)
    {
        string jsonString = JsonSerializer.Serialize(students);
        File.WriteAllText(filePath, jsonString);
    }

    public List<T> DeserializeFromJson<T>(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<T>>(jsonString);
    }

    public void SerializeToXml<T>(List<T> students, string filePath)
    {
        using (StreamWriter streamWriter = new StreamWriter(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            serializer.Serialize(streamWriter, students);
        }
    }

    public List<T> DeserializeFromXml<T>(string filePath)
    {
        using (StreamReader streamReader = new StreamReader(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            return (List<T>)serializer.Deserialize(streamReader);
        }
    }

    public void SerializeToBinary<T>(List<T> students, string filePath)
    {
        using (FileStream fileStream = File.Create(filePath))
        {
            Serializer.Serialize(fileStream, students);
        }
    }

    public List<T> DeserializeFromBinary<T>(string filePath)
    {
        using (FileStream fileStream = File.OpenRead(filePath))
        {
            return Serializer.Deserialize<List<T>>(fileStream);
        }
    }
}

////2.6
//[ProtoContract]
//struct Driver
//{
//    [ProtoMember(1)]
//    public string LastName { get; set; }
//    [ProtoMember(2)]
//    public int[] Scores { get; set; }

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

//class DivingSerializer
//{
//    public void SerializeToJson(Driver[] drivers, string filePath)
//    {
//        string jsonString = JsonSerializer.Serialize(drivers);
//        File.WriteAllText(filePath, jsonString);
//    }

//    public Driver[] DeserializeFromJson(string filePath)
//    {
//        string jsonString = File.ReadAllText(filePath);
//        return JsonSerializer.Deserialize<Driver[]>(jsonString);
//    }

//    public void SerializeToXml(Driver[] drivers, string filePath)
//    {
//        using (StreamWriter streamWriter = new StreamWriter(filePath))
//        {
//            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Driver[]));
//            serializer.Serialize(streamWriter, drivers);
//        }
//    }

//    public Driver[] DeserializeFromXml(string filePath)
//    {
//        using (StreamReader streamReader = new StreamReader(filePath))
//        {
//            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Driver[]));
//            return (Driver[])serializer.Deserialize(streamReader);
//        }
//    }

//    public void SerializeToBinary(Driver[] drivers, string filePath)
//    {
//        using (FileStream fileStream = File.Create(filePath))
//        {
//            Serializer.Serialize(fileStream, drivers);
//        }
//    }

//    public Driver[] DeserializeFromBinary(string filePath)
//    {
//        using (FileStream fileStream = File.OpenRead(filePath))
//        {
//            return Serializer.Deserialize<Driver[]>(fileStream);
//        }
//    }
//}

////3.3
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text.Json;
//using System.Linq;

//class Team
//{
//    public string Name { get; set; }
//    public int[] Places { get; set; }

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

//class TeamSerializer
//{
//    public void SerializeToJson(Team[] teams, string filePath)
//    {
//        string jsonString = JsonSerializer.Serialize(teams);
//        File.WriteAllText(filePath, jsonString);
//    }

//    public Team[] DeserializeFromJson(string filePath)
//    {
//        string jsonString = File.ReadAllText(filePath);
//        return JsonSerializer.Deserialize<Team[]>(jsonString);
//    }

//    public void SerializeToXml(Team[] teams, string filePath)
//    {
//        using (StreamWriter streamWriter = new StreamWriter(filePath))
//        {
//            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Team[]));
//            serializer.Serialize(streamWriter, teams);
//        }
//    }

//    public Team[] DeserializeFromXml(string filePath)
//    {
//        using (StreamReader streamReader = new StreamReader(filePath))
//        {
//            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Team[]));
//            return (Team[])serializer.Deserialize(streamReader);
//        }
//    }

//    public void SerializeToBinary(Team[] teams, string filePath)
//    {
//        using (FileStream fileStream = File.Create(filePath))
//        {
//            Serializer.Serialize(fileStream, teams);
//        }
//    }

//    public Team[] DeserializeFromBinary(string filePath)
//    {
//        using (FileStream fileStream = File.OpenRead(filePath))
//        {
//            return Serializer.Deserialize<Team[]>(fileStream);
//        }
//    }
//}


class Program
{
    static void Main(string[] args)
    {
        // для 1.5
        Lesson computerScienceLesson = new ComputerScienceLesson();
        Lesson mathLesson = new MathLesson();

        computerScienceLesson.AddStudent("Анна", 2, 3);
        computerScienceLesson.AddStudent("Иван", 2, 1);
        computerScienceLesson.AddStudent("Мария", 2, 4);
        computerScienceLesson.AddStudent("Петр", 3, 0);

        mathLesson.AddStudent("Елена", 5, 2);
        mathLesson.AddStudent("Алексей", 5, 0);
        mathLesson.AddStudent("Дмитрий", 4, 1);
        mathLesson.AddStudent("Ольга", 3, 3);

        var lessonSerializer = new LessonSerializer();
        var computerScienceStudents = computerScienceLesson.GetStudents();
        lessonSerializer.SerializeToJson(computerScienceStudents, "ComputerScienceStudents.json");
        lessonSerializer.SerializeToXml(computerScienceStudents, "ComputerScienceStudents.xml");
        lessonSerializer.SerializeToBinary(computerScienceStudents, "ComputerScienceStudents.bin");

        var mathStudents = mathLesson.GetStudents();
        lessonSerializer.SerializeToJson(mathStudents, "MathStudents.json");
        lessonSerializer.SerializeToXml(mathStudents, "MathStudents.xml");
        lessonSerializer.SerializeToBinary(mathStudents, "MathStudents.bin");

        // Десериализация примера
        var deserializedComputerScienceStudentsJson = lessonSerializer.DeserializeFromJson<Student>("ComputerScienceStudents.json");
        var deserializedComputerScienceStudentsXml = lessonSerializer.DeserializeFromXml<Student>("ComputerScienceStudents.xml");
        var deserializedComputerScienceStudentsBinary = lessonSerializer.DeserializeFromBinary<Student>("ComputerScienceStudents.bin");

        var deserializedMathStudentsJson = lessonSerializer.DeserializeFromJson<Student>("MathStudents.json");
        var deserializedMathStudentsXml = lessonSerializer.DeserializeFromXml<Student>("MathStudents.xml");
        var deserializedMathStudentsBinary = lessonSerializer.DeserializeFromBinary<Student>("MathStudents.bin");

        // Проверка результатов десериализации
        Console.WriteLine("Десериализованные данные:");
        Console.WriteLine("Computer Science Students (JSON):");
        foreach (var student in deserializedComputerScienceStudentsJson)
        {
            Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Absences: {student.Absences}");
        }
        Console.WriteLine("Computer Science Students (XML):");
        foreach (var student in deserializedComputerScienceStudentsXml)
        {
            Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Absences: {student.Absences}");
        }
        Console.WriteLine("Computer Science Students (Binary):");
        foreach (var student in deserializedComputerScienceStudentsBinary)
        {
            Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Absences: {student.Absences}");
        }
        Console.WriteLine("Math Students (JSON):");
        foreach (var student in deserializedMathStudentsJson)
        {
            Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Absences: {student.Absences}");
        }
        Console.WriteLine("Math Students (XML):");
        foreach (var student in deserializedMathStudentsXml)
        {
            Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Absences: {student.Absences}");
        }
        Console.WriteLine("Math Students (Binary):");
        foreach (var student in deserializedMathStudentsBinary)
        {
            Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Absences: {student.Absences}");
        }

        //// для 2.6
        //Driver[] drivers = new Driver[]
        //{
        //    new Driver { LastName = "Иванов", Scores = new int[] { 8, 9 }},
        //    new Driver { LastName = "Петров", Scores = new int[] { 7, 8 }},
        //    new Driver { LastName = "Сидоров", Scores = new int[] { 9, 9 }},
        //    new Driver { LastName = "Козлов", Scores = new int[] { 6, 7 }},
        //    new Driver { LastName = "Смирнов", Scores = new int[] { 8, 8 }}
        //};

        //Diving3m diving3m = new Diving3m("Прыжки с 3-метровой вышки");
        //diving3m.GenerateProtocol(drivers);

        //Diving5m diving5m = new Diving5m("Прыжки с 5-метровой вышки");
        //diving5m.GenerateProtocol(drivers);

        //var divingSerializer = new DivingSerializer();
        //divingSerializer.SerializeToJson(drivers, "Drivers.json");
        //divingSerializer.SerializeToXml(drivers, "Drivers.xml");
        //divingSerializer.SerializeToBinary(drivers, "Drivers.bin");

        //// для 3.3
        //Team[] menTeams = new Team[]
        //{
        //    new MenTeam("Мужская 1", new int[] { 1, 2, 3, 4, 5, 6 }),
        //    new MenTeam("Мужская 2", new int[] { 7, 8, 9, 10, 11, 12 }),
        //    new MenTeam("Мужская 3", new int[] { 13, 14, 15, 16, 17, 18 })
        //};

        //Team[] womenTeams = new Team[]
        //{
        //    new WomenTeam("Женская 1", new int[] { 1, 2, 3, 4, 5, 6 }),
        //    new WomenTeam("Женская 2", new int[] { 7, 8, 9, 10, 11, 12 }),
        //    new WomenTeam("Женская 3", new int[] { 13, 14, 15, 16, 17, 18 })
        //};

        //Competition competition = new Competition(menTeams, womenTeams);
        //competition.DetermineWinner();

        //var teamSerializer = new TeamSerializer();
        //teamSerializer.SerializeToJson(menTeams.Concat(womenTeams).ToArray(), "Teams.json");
        //teamSerializer.SerializeToXml(menTeams.Concat(womenTeams).ToArray(), "Teams.xml");
        //teamSerializer.SerializeToBinary(menTeams.Concat(womenTeams).ToArray(), "Teams.bin");
    }
}
