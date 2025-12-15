using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Exercise #1");
        var dog = new Dog();
        dog.Name = "Шарик";
        dog.Eat();
        dog.Bark();

        var cat = new Cat();
        cat.Name = "Мурка";
        cat.Eat();
        cat.Meow();
        
        Console.WriteLine("Exercise #2");
        dog.Speak();
        cat.Speak();
        
        Console.WriteLine("Exercise #3");
        dog.Move();
        
        Console.WriteLine("Exercise #4");
        var cat2 = new Cat("Мурка");
        
        Console.WriteLine("Exercise #5");
        var transport = new Transport();
        var car = new Car();
        var tesla = new ElectricCar();

        transport.Drive();
        car.Drive();
        tesla.Drive();
    }
}

public class Animal
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Создано животное: {Name}");
    }
    public Animal() { }
    
    public virtual void Speak()
    {
        Console.WriteLine($"{Name} издаёт звук");
    }
    public void Eat()
    {
        Console.WriteLine($"{Name} ест");
    }

    public virtual void Move()
    {
        Console.WriteLine($"{Name} двигается.");
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
        Console.WriteLine($"Создана кошка по имени {Name}");
    }
    public Cat() : base() { }
    
    public void Meow()
    {
        Console.WriteLine($"{Name} мяукает");
    }

    public override void Speak()
    {
        Console.WriteLine("Кошка говорит: Мяу!");
    }
}

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        Console.WriteLine($"Создана собака по имени {Name}");
    }

    public Dog() : base() { }

    public void Bark()
    {
        Console.WriteLine($"{Name} лает");
    }
    public override void Speak()
    {
        Console.WriteLine("Собака говорит: Гав-гав!");
    }

    public virtual void Move()
    {
        base.Move();
        Console.WriteLine("Собака бежит по дороге.");
    }
}

public class Transport
{
    public virtual void Drive()
    {
        Console.WriteLine("Транспорт движется");
    }
}
public class Car : Transport
{
    public override void Drive()
    {
        Console.WriteLine("Машина едет по дороге");
    }
}
public class ElectricCar : Car
{
    public override void Drive()
    {
        Console.WriteLine("Электромобиль тихо едет на батарее");
    }
}