using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/////////////////////////
/// TSK 2
public class Car
{

    public string Make { get; set; }
    public int Year { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }
    public string Model { get; set; }
    public string PalletNo { get; set; }
    public string Color { get; set; }

    public Car(string make, int year, string type, decimal price, string model, string palletNo, string color)
    {
        Make = make;
        Year = year;
        Type = type;
        Price = price;
        Model = model;
        PalletNo = palletNo;
        Color = color;
    }


    public void DisplayInfo(string make, int year)
    {
        Console.WriteLine($"Car Make: {make}, Year: {year}");

    }
    public void DisplayInfo(string make)
    {
        Console.WriteLine($"Car Make: {make}");

    }
    public virtual void Display()
    {
        Console.WriteLine("Welcome Car");
    }



}
public class BMW : Car
{
    public BMW(string make, int year, string type, decimal price, string model, string palletNo, string color)
        : base(make, year, type, price, model, palletNo, color)
    {
    }

    public override void Display()
    {
        Console.WriteLine("Welcome BMW");
    }
}

public class Program
{
    public static void Main()
    {

        BMW myBMW = new BMW("BMW", 2022, "Sedan", 55000, "M3", "123ABC", "Blue");

        myBMW.Display();
        myBMW.DisplayInfo(myBMW.Make);
        myBMW.DisplayInfo(myBMW.Make, myBMW.Year);
    }
}

/////////////////////////
/// TSK 2


interface ISound
{
    void MakeSound();
}

public abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void Eat();

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }
}

public class Cat : Animal, ISound
{
    public Cat(string name) : base(name) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} is eating Tuna");
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name} says: kefak ya 8araba!");
    }
}

public class Dog : Animal, ISound
{
    public Dog(string name) : base(name) { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} is eating chicken");
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name} says: Kefak m3lm!");
    }
}

public class Program
{
    static void Main(string[] args)
    {

        Dog myDog = new Dog("Dog1");
        Cat myCat = new Cat("BussBuss");


        myDog.Eat();
        myDog.Sleep();
        myDog.MakeSound();

        myCat.Eat();
        myCat.Sleep();
        myCat.MakeSound();
    }
}