using System;

abstract class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string VIM { get; set; }
    public int Year { get; set; }

    public Vehicle(string brand, string model, string vim, int year)
    {
        Brand = brand;
        Model = model;
        VIM = vim;
        Year = year;
    }

    public abstract void PrintInfo();
}

class Car : Vehicle
{
    public string CarClass { get; set; }

    public Car(string brand, string model, string vim, int year, string carClass)
        : base(brand, model, vim, year)
    {
        CarClass = carClass;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Марка: {Brand}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"VIM: {VIM}");
        Console.WriteLine($"Год выпуска: {Year}");
        Console.WriteLine($"Класс машины: {CarClass}");
        Console.WriteLine();
    }
}

class Truck : Vehicle
{
    public int WheelsCount { get; set; }

    public Truck(string brand, string model, string vim, int year, int wheelsCount)
        : base(brand, model, vim, year)
    {
        WheelsCount = wheelsCount;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Марка: {Brand}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"VIM: {VIM}");
        Console.WriteLine($"Год выпуска: {Year}");
        Console.WriteLine($"Количество колес: {WheelsCount}");
        Console.WriteLine();
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(string brand, string model, string vim, int year)
        : base(brand, model, vim, year)
    {
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Марка: {Brand}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"VIM: {VIM}");
        Console.WriteLine($"Год выпуска: {Year}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[15];

        vehicles[0] = new Car("Toyota", "Corolla", "123456789", 2018, "A");
        vehicles[1] = new Car("BMW", "X5", "987654321", 2019, "B");
        vehicles[2] = new Car("Mercedes", "E-Class", "567891234", 2020, "C");
        vehicles[3] = new Car("Ford", "Focus", "456789123", 2015, "A");
        vehicles[4] = new Car("Honda", "Civic", "321654987", 2017, "B");

        vehicles[5] = new Truck("Volvo", "FH", "654789321", 2016, 6);
        vehicles[6] = new Truck("Scania", "R0", "789321654", 2019, 8);
        vehicles[7] = new Truck("MAN", "TX", "987123456", 2014, 6);
        vehicles[8] = new Truck("Iveco", "Ss", "159753468", 2018, 8);
        vehicles[9] = new Truck("Kenworth", "T0", "369852147", 2021, 10);

        vehicles[10] = new Motorcycle("Harley-Davidson", "Sportster", "753951852", 2017);
        vehicles[11] = new Motorcycle("Honda", "CRR", "852369741", 2020);
        vehicles[12] = new Motorcycle("Yamaha", "R6", "654123987", 2019);
        vehicles[13] = new Motorcycle("Kawasaki", "Ninja", "987654123", 2018);
        vehicles[14] = new Motorcycle("Suzuki", "GSX600", "369874125", 2016);

        Array.Sort(vehicles, (x, y) => x.Year.CompareTo(y.Year));

        Console.WriteLine("Информация о машинах:");
        Console.WriteLine("======================");
        foreach (var vehicle in vehicles)
        {
            if (vehicle is Car)
            {
                vehicle.PrintInfo();
            }
        }

        Console.WriteLine("Информация о грузовиках:");
        Console.WriteLine("======================");
        foreach (var vehicle in vehicles)
        {
            if (vehicle is Truck)
            {
                vehicle.PrintInfo();
            }
        }

        Console.WriteLine("Информация о мотоциклах:");
        Console.WriteLine("======================");
        foreach (var vehicle in vehicles)
        {
            if (vehicle is Motorcycle)
            {
                vehicle.PrintInfo();
            }
        }
        Console.WriteLine("Информация обо всех транспортных средствах:");
        Console.WriteLine("======================");
        foreach (var vehicle in vehicles)
        {
            vehicle.PrintInfo();
        }
    }
}
