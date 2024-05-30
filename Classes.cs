using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;
using Interfaces;

namespace Classes
{
    [JsonDerivedType(typeof(MusicFestival), typeDiscriminator: "Music Festival")]
    [JsonDerivedType(typeof(ComicsFestival), typeDiscriminator: "Comics Festival")]
    [JsonDerivedType(typeof(FoodFestival), typeDiscriminator: "Food Festival")]
    [XmlInclude(typeof(MusicFestival))]
    [XmlInclude(typeof(ComicsFestival))]
    [XmlInclude(typeof(FoodFestival))]
    public abstract partial class Festival
    {
        private string name;
        private string location;
        private DateTime startDate;
        private DateTime endDate;
        private decimal totalAmount;
        private decimal ticketPrice;
        public string Name { get { return name; } set { name = value ?? string.Empty; } }
        public string Location { get { return location; } set { location = value ?? string.Empty; } }
        public DateTime StartDate { get { return startDate; } set { startDate = value; } }
        public DateTime EndDate { get { return endDate; } set { endDate = value; } }
        public decimal TotalAmount { get { return totalAmount; } set { totalAmount = value; } }
        public decimal TicketPrice { get { return ticketPrice; } set { ticketPrice = value; } }

        public Festival(string name, string location, DateTime startDate, DateTime endDate, decimal ticketPrice)
        {
            Name = name;
            Location = location;
            StartDate = startDate;
            EndDate = endDate;
            TicketPrice = ticketPrice;
            TotalAmount = CalculatePrice();
        }
        public Festival() { }

        public abstract decimal CalculatePrice();

        public override string ToString()
        {
            return $"Name: {Name}, Location: {Location}, Start Date: {StartDate:yyyy-MM-dd}, End Date: {EndDate:yyyy-MM-dd}, Total Amount: {TotalAmount:C}, Ticket Price: {TicketPrice:C}";
        }
    }

    public class MusicFestival : Festival
    {
        private string headLiner;
        private int numberOfBands;
        public string Headliner { get { return headLiner; } set { headLiner = value; } }
        public int NumberOfBands { get { return numberOfBands; } set { numberOfBands = value; } }
        public MusicFestival() : base() { }

        public MusicFestival(string name, string location, DateTime startDate, DateTime endDate, decimal ticketPrice, string headliner, int numberOfBands)
            : base(name, location, startDate, endDate, ticketPrice)
        {
            Headliner = headliner;
            NumberOfBands = numberOfBands;
        }

        public override decimal CalculatePrice()
        {
            return 5 * NumberOfBands * (EndDate - StartDate).Days;
        }
    }

    public class ComicsFestival : Festival
    {
        private string mainCharacter;
        private int numberOfIssues;
        public string MainCharacter { get { return mainCharacter; } set { mainCharacter = value; } }
        public int NumberOfIssues { get { return numberOfIssues; } set { numberOfIssues = value; } }
        public ComicsFestival() : base() { }
        public ComicsFestival(string name, string location, DateTime startDate, DateTime endDate, decimal ticketPrice, string mainCharacter, int numberOfIssues)
            : base(name, location, startDate, endDate, ticketPrice)
        {
            MainCharacter = mainCharacter;
            NumberOfIssues = numberOfIssues;
        }

        public ComicsFestival(DateTime startDate, DateTime endDate, Festival festival, string mainCharacter, int numberOfIssues)
        {
            if (Char.IsDigit(festival.Name[festival.Name.Length - 1])) 
            {
                string tempName = festival.Name;
                int lastDigit = Name[Name.Length - 1] + 1;
                Name = tempName.Substring(0, Name.Length - 1) + lastDigit;
            }
            else Name = festival.Name + "1";
            MainCharacter = mainCharacter;
            NumberOfIssues = numberOfIssues;
            StartDate = startDate;
            EndDate = endDate;
            Location = festival.Location;
            TicketPrice = festival.TicketPrice;
        }

        public override decimal CalculatePrice()
        {
            return 5 * NumberOfIssues * (EndDate - StartDate).Days;
        }
    }

    public class FoodFestival : Festival
    {
        private string cuicineType;
        private int numberOfVendors;
        public string CuisineType { get { return cuicineType; } set { cuicineType = value; } }
        public int NumberOfVendors { get { return numberOfVendors; } set { numberOfVendors = value; } }
        public FoodFestival() : base() { }

        public FoodFestival(string name, string location, DateTime startDate, DateTime endDate, decimal ticketPrice, string cuisineType, int numberOfVendors)
            : base(name, location, startDate, endDate, ticketPrice)
        {
            CuisineType = cuisineType;
            NumberOfVendors = numberOfVendors;
        }

        public override decimal CalculatePrice()
        {
            return 5 * NumberOfVendors * (EndDate - StartDate).Days;
        }
    }
    public class FestivalCalendar
    {
        private List<Festival> festivals = new List<Festival> { };
        public List<Festival> Festivals { get { return festivals; } set { festivals = value; } }

        public FestivalCalendar()
        {

        }

        public void AddFestival(Festival festival)
        {
            festivals.Add(festival);
        }

        public void ShowFestivals()
        {
            foreach (var festival in festivals)
            {
                Console.WriteLine(festival);
            }
        }

        public void ShowFestivals(DateTime startDate)
        {
            foreach (var festival in festivals)
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
}