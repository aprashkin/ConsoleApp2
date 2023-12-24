using System;
using System.Collections.Generic;

// Базовый класс Vehicle
public abstract class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public virtual void Start()
    {
        Console.WriteLine($"{Make} {Model} is starting.");
    }

    public virtual void Stop()
    {
        Console.WriteLine($"{Make} {Model} is stopping.");
    }
}

// Производный класс Car
public class Car : Vehicle
{
    public int PassengerCapacity { get; set; }

    public Car(string make, string model, int year, int passengerCapacity)
        : base(make, model, year)
    {
        PassengerCapacity = passengerCapacity;
    }

    public override void Start()
    {
        Console.WriteLine($"Car {Make} {Model} is starting with passenger capacity: {PassengerCapacity}");
    }
}

// Производный класс Truck
public class Truck : Vehicle
{
    public float LoadCapacity { get; set; }

    public Truck(string make, string model, int year, float loadCapacity)
        : base(make, model, year)
    {
        LoadCapacity = loadCapacity;
    }

    public override void Start()
    {
        Console.WriteLine($"Truck {Make} {Model} is starting with load capacity: {LoadCapacity} tons");
    }
}

// Производный класс Motorcycle
public class Motorcycle : Vehicle
{
    public Motorcycle(string make, string model, int year)
        : base(make, model, year)
    {
    }

    public void DoWheelie()
    {
        Console.WriteLine($"Motorcycle {Make} {Model} is doing a wheelie!");
    }
}

public class Program
{
    public static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("Toyota", "Corolla", 2020, 5),
            new Truck("Ford", "F-150", 2019, 1.5f),
            new Motorcycle("Harley-Davidson", "Street 750", 2021)
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.Start();
            vehicle.Stop();

            if (vehicle is Motorcycle motorcycle)
            {
                motorcycle.DoWheelie();
            }

            Console.WriteLine();
        }
    }
}
