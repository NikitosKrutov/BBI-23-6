using System;

struct Car
{
    private string Brand { get; set; }
    private string Model { get; set; }
    private string VIM { get; set; }
    private int Year { get; set; }
    public int Probeg { get; set; }
    public Car(string brand, string model, string vim, int year, int probeg)
    {
        Brand = brand;
        Model = model;
        VIM = vim;
        Year = year;
        Probeg = probeg;
    }

    public string GetUsageType()
    {
        int annualMileage = Probeg / (DateTime.Now.Year - Year);

        if (annualMileage > 500)
            return "Рабочая";
        else if (annualMileage >= 100)
            return "Праздничная";
        else
            return "Простаивающая";
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Марка: {Brand}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"VIM: {VIM}");
        Console.WriteLine($"Год выпуска: {Year}");
        Console.WriteLine($"Пробег: {Probeg} км");
        Console.WriteLine($"Характеристика: {GetUsageType()}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car[] cars = new Car[5];

        cars[0] = new Car("Toyota", "Corolla", "123456789", 2018, 20000);
        cars[1] = new Car("BMW", "X5", "987654321", 2019, 1000);
        cars[2] = new Car("Mercedes", "E-Class", "567891234", 2020, 300);
        cars[3] = new Car("Ford", "Focus", "456789123", 2015, 60000);
        cars[4] = new Car("Honda", "Civic", "321654987", 2017, 1500);

        for (int i = 0; i < cars.Length - 1; i++)
        {
            for (int j = i + 1; j < cars.Length; j++)
            {
                if (cars[i].Probeg > cars[j].Probeg)
                {
                    Car temp = cars[i];
                    cars[i] = cars[j];
                    cars[j] = temp;
                }
            }
        }

        Console.WriteLine("Информация о машинах:");
        Console.WriteLine("======================");
        foreach (var car in cars)
        {
            car.PrintInfo();
        }
    }
}
