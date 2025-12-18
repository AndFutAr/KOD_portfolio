using System;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Exercise #1");
        var p = new Person();
        p.Name = "Алиса";
        p.Age = 25;
        p.Age = -5;
        
        Console.WriteLine("Exercise #2");
        var ba = new BankAccount();
        ba.Deposit(10);
        ba.Withdraw(20);
        Console.WriteLine(ba.ShowBalance);
        ba.Withdraw(5);
        
        Console.WriteLine("Exercise #3");
        var t = new Thermometer();
        t.TemperatureCelsius = 25;
        Console.WriteLine(t.TemperatureFahrenheit);
        
        Console.WriteLine("Exercise #4");
        var d = new Dog();
        d.Eat();
        d.Run();
        d.Eat();
        d.Run();
    }
}

public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length != 0)
                name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
            else Console.WriteLine("Error");
        }
    }
}

public class BankAccount
{
    private decimal balance = 0;

    public decimal ShowBalance => balance;
    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
            balance -= amount;
        else
            Console.WriteLine("Error");
    }
}

public class Thermometer
{
    private float temperatureCelsius = 0;

    public float TemperatureCelsius
    {
        get { return temperatureCelsius; }
        set
        {
            if (value >= -273)
                temperatureCelsius = value;
        }
    }

    public float TemperatureFahrenheit
    {
        get { return temperatureCelsius * 9 / 5 + 32; }
    }
}

public class Animal
{
    protected int energy = 0;
    
    public void Eat() => energy += 10;
}

public class Dog : Animal
{
    public void Run()
    {
        if (energy >= 20)
            energy -= 20;
        else Console.WriteLine("Error");
    }
}