using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public abstract partial class Festival
{
    public string Name { get; set; }
    public string Location { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal TicketPrice { get; set; }

    public Festival(string name, string location, DateTime startDate, DateTime endDate, decimal ticketPrice)
    {
        Name = name;
        Location = location;
        StartDate = startDate;
        EndDate = endDate;
        TicketPrice = ticketPrice;
        TotalAmount = CalculatePrice();
    }

    public abstract decimal CalculatePrice();

    public override string ToString()
    {
        return $"Name: {Name}, Location: {Location}, Start Date: {StartDate:yyyy-MM-dd}, End Date: {EndDate:yyyy-MM-dd}, Total Amount: {TotalAmount:C}, Ticket Price: {TicketPrice:C}";
    }
}

public partial class Festival : ICounter
{
    public int DailyFlow { get; set; }
    public decimal Revenue { get; set; }
    public decimal DailyRevenue { get; set; }
}

public class MusicFestival : Festival
{
    public string Headliner { get; set; }
    public int NumberOfBands { get; set; }

    public MusicFestival(string name, string location, DateTime startDate, DateTime endDate, decimal ticketPrice, string headliner, int numberOfBands)
        : base(name, location, startDate, endDate, ticketPrice)
    {
        Headliner = headliner;
        NumberOfBands = numberOfBands;
    }

    public override decimal CalculatePrice()
    {
        return TicketPrice * NumberOfBands * (EndDate - StartDate).Days;
    }
}

public class ComicsFestival : Festival
{
    public string MainCharacter { get; set; }
    public int NumberOfIssues { get; set; }

    public ComicsFestival(string name, string location, DateTime startDate, DateTime endDate, decimal ticketPrice, string mainCharacter, int numberOfIssues)
        : base(name, location, startDate, endDate, ticketPrice)
    {
        MainCharacter = mainCharacter;
        NumberOfIssues = numberOfIssues;
    }

    public override decimal CalculatePrice()
    {
        return TicketPrice * NumberOfIssues * (EndDate - StartDate).Days;
    }
}

public class FoodFestival : Festival
{
    public string CuisineType { get; set; }
    public int NumberOfVendors { get; set; }

    public FoodFestival(string name, string location, DateTime startDate, DateTime endDate, decimal ticketPrice, string cuisineType, int numberOfVendors)
        : base(name, location, startDate, endDate, ticketPrice)
    {
        CuisineType = cuisineType;
        NumberOfVendors = numberOfVendors;
    }

    public override decimal CalculatePrice()
    {
        return TicketPrice * NumberOfVendors * (EndDate - StartDate).Days;
    }
}

public interface ICounter
{
    int DailyFlow { get; set; }
    decimal Revenue { get; set; }
    decimal DailyRevenue { get; set; }
}

public class FestivalCalendar
{
    public List<Festival> Festivals { get; set; }

    public FestivalCalendar()
    {
        Festivals = new List<Festival>();
    }

    public void AddFestival(Festival festival)
    {
        Festivals.Add(festival);
    }

    public void ShowFestivals()
    {
        foreach (var festival in Festivals)
        {
            Console.WriteLine(festival);
        }
    }

    public void ShowFestivals(DateTime startDate)
    {
        foreach (var festival in Festivals)
        {
            if (festival.StartDate >= startDate)
            {
                Console.WriteLine(festival);
            }
        }
    }

    public void ShowFestivals(DateTime startDate, DateTime endDate)
    {
        foreach (var festival in Festivals)
        {
            if (festival.StartDate >= startDate && festival.EndDate <= endDate)
            {
                Console.WriteLine(festival);
            }
        }
    }
}

public abstract class MySerializer
{
    public abstract void Read(string fileName);
    public abstract void Write(FestivalCalendar calendar, string fileName);
}

public class MyJsonSerializer : MySerializer
{
    public override void Read(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);
        List<Festival> festivals = JsonSerializer.Deserialize<List<Festival>>(jsonString, new JsonSerializerOptions
        {
            Converters = { new FestivalConverter() }
        });

        FestivalCalendar calendar = new FestivalCalendar();
        foreach (var festival in festivals)
        {
            calendar.AddFestival(festival);
        }
        calendar.ShowFestivals();
    }

    public override void Write(FestivalCalendar calendar, string fileName)
    {
        string jsonString = JsonSerializer.Serialize(calendar.Festivals, new JsonSerializerOptions
        {
            Converters = { new FestivalConverter() },
            WriteIndented = true
        });
        File.WriteAllText(fileName, jsonString);
    }
}

public class FestivalConverter : JsonConverter<Festival>
{
    public override Festival Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            JsonElement element = doc.RootElement;
            string type = element.GetProperty("Type").GetString();
            switch (type)
            {
                case nameof(MusicFestival):
                    return JsonSerializer.Deserialize<MusicFestival>(element.GetRawText(), options);
                case nameof(ComicsFestival):
                    return JsonSerializer.Deserialize<ComicsFestival>(element.GetRawText(), options);
                case nameof(FoodFestival):
                    return JsonSerializer.Deserialize<FoodFestival>(element.GetRawText(), options);
                default:
                    throw new NotSupportedException($"Unknown type: {type}");
            }
        }
    }

    public override void Write(Utf8JsonWriter writer, Festival value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("Type", value.GetType().Name);
        writer.WritePropertyName("Data");
        JsonSerializer.Serialize(writer, (object)value, options);
        writer.WriteEndObject();
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var festivals = new List<Festival>
        {
            new MusicFestival("RockFest", "New York", new DateTime(2024, 6, 1), new DateTime(2024, 6, 3), 50, "Band A", 5),
            new ComicsFestival("ComicCon", "San Diego", new DateTime(2023, 4, 10), new DateTime(2023, 4, 12), 100, "Character A", 10),
            new FoodFestival("Taste of Chicago", "Chicago", new DateTime(2021, 8, 15), new DateTime(2021, 8, 17), 20, "Cuisine A", 15)
        };

        FestivalCalendar calendar = new FestivalCalendar();
        foreach (var festival in festivals)
        {
            calendar.AddFestival(festival);
        }

        MyJsonSerializer jsonSerializer = new MyJsonSerializer();
        jsonSerializer.Write(calendar, "raw_data.json");

        Console.WriteLine("All Festivals:");
        calendar.ShowFestivals();

        Console.WriteLine("\nFestivals from 01.04.2023:");
        calendar.ShowFestivals(new DateTime(2023, 4, 1));

        Console.WriteLine("\nFestivals from 20.05.2020 to 21.09.2021:");
        calendar.ShowFestivals(new DateTime(2020, 5, 20), new DateTime(2021, 9, 21));
    }
}
