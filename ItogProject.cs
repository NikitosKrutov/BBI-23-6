//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text.Json;

//public abstract partial class Festival
//{
//    public string Name { get; set; }
//    public string Location { get; set; }
//    public DateTime StartDate { get; set; }
//    public DateTime EndDate { get; set; }
//    public decimal TotalAmount { get; set; }
//    public decimal TicketPrice { get; set; }

//    public abstract decimal CalculatePrice();
//    public override string ToString()
//    {
//        return $"Name: {Name}, Location: {Location}, Start Date: {StartDate}, End Date: {EndDate}, Total Amount: {TotalAmount:C}, Ticket Price: {TicketPrice:C}";
//    }
//}

//public class MusicFestival : Festival
//{
//    public string Headliner { get; set; }
//    public int NumberOfBands { get; set; }

//    public override decimal CalculatePrice()
//    {
//        return TicketPrice * (EndDate - StartDate).Days;
//    }
//}

//public class ComicsFestival : Festival
//{
//    public string MainCharacter { get; set; }
//    public int NumberOfIssues { get; set; }

//    public override decimal CalculatePrice()
//    {
//        return TicketPrice * NumberOfIssues;
//    }
//}

//public class FoodFestival : Festival
//{
//    public string CuisineType { get; set; }
//    public int NumberOfVendors { get; set; }

//    public override decimal CalculatePrice()
//    {
//        return TicketPrice * NumberOfVendors;
//    }
//}

//public interface ICounter
//{
//    int DailyFlow { get; set; }
//    decimal Revenue { get; set; }
//    decimal DailyRevenue { get; set; }
//}

//public partial class Festival : ICounter
//{
//    public int DailyFlow { get; set; }
//    public decimal Revenue { get; set; }
//    public decimal DailyRevenue { get; set; }
//}

//public class FestivalCalendar
//{
//    private List<Festival> festivals;

//    public FestivalCalendar()
//    {
//        festivals = new List<Festival>();
//    }

//    public void AddFestival(Festival festival)
//    {
//        festivals.Add(festival);
//    }

//    public void ShowFestivals()
//    {
//        foreach (var festival in festivals)
//        {
//            Console.WriteLine(festival);
//        }
//    }

//    public void ShowFestivals(DateTime startDate)
//    {
//        foreach (var festival in festivals)
//        {
//            if (festival.StartDate >= startDate)
//            {
//                Console.WriteLine(festival);
//            }
//        }
//    }

//    public void ShowFestivals(DateTime startDate, DateTime endDate)
//    {
//        foreach (var festival in festivals)
//        {
//            if (festival.StartDate >= startDate && festival.EndDate <= endDate)
//            {
//                Console.WriteLine(festival);
//            }
//        }
//    }
//}

//public abstract class MySerializer
//{
//    public abstract void Read(string fileName);
//    public abstract void Write(FestivalCalendar calendar, string fileName);
//}

//public class MyJsonSerializer : MySerializer
//{
//    public override void Read(string fileName)
//    {
//        string jsonString = File.ReadAllText(fileName);
//        FestivalCalendar calendar = JsonSerializer.Deserialize<FestivalCalendar>(jsonString);
//        calendar.ShowFestivals();
//    }

//    public override void Write(FestivalCalendar calendar, string fileName)
//    {
//        string jsonString = JsonSerializer.Serialize(calendar);
//        File.WriteAllText(fileName, jsonString);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        MusicFestival musicFestival1 = new MusicFestival
//        {
//            Name = "RockFest",
//            Location = "New York",
//            StartDate = new DateTime(2024, 6, 1),
//            EndDate = new DateTime(2024, 6, 3),
//            TotalAmount = 50000,
//            TicketPrice = 50,
//            Headliner = "Metallica",
//            NumberOfBands = 10
//        };

//        ComicsFestival comicsFestival1 = new ComicsFestival
//        {
//            Name = "ComicCon",
//            Location = "San Diego",
//            StartDate = new DateTime(2024, 7, 10),
//            EndDate = new DateTime(2024, 7, 12),
//            TotalAmount = 100000,
//            TicketPrice = 100,
//            MainCharacter = "Spider-Man",
//            NumberOfIssues = 20
//        };

//        FoodFestival foodFestival1 = new FoodFestival
//        {
//            Name = "Taste of Chicago",
//            Location = "Chicago",
//            StartDate = new DateTime(2024, 8, 15),
//            EndDate = new DateTime(2024, 8, 17),
//            TotalAmount = 80000,
//            TicketPrice = 20,
//            CuisineType = "American",
//            NumberOfVendors = 50
//        };

//        FestivalCalendar calendar = new FestivalCalendar();
//        calendar.AddFestival(musicFestival1);
//        calendar.AddFestival(comicsFestival1);
//        calendar.AddFestival(foodFestival1);

//        MyJsonSerializer jsonSerializer = new MyJsonSerializer();
//        jsonSerializer.Write(calendar, "raw_data.json");

//        Console.WriteLine("All Festivals:");
//        calendar.ShowFestivals();

//        Console.WriteLine("\nFestivals from 01.07.2024:");
//        calendar.ShowFestivals(new DateTime(2024, 7, 1));

//        Console.WriteLine("\nFestivals from 01.07.2024 to 30.07.2024:");
//        calendar.ShowFestivals(new DateTime(2024, 7, 1), new DateTime(2024, 7, 30));

//        jsonSerializer.Read("raw_data.json");
//    }
//}
