using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Exercise #1");
        var b1 = new Book();
        var b2 = new Book("1984");
        var b3 = new Book("Гарри Поттер", "Дж. Роулинг", 500);

        b1.PrintInfo();
        b2.PrintInfo();
        b3.PrintInfo();

        Console.WriteLine("Exercise #3");
        var p1 = new Player("Alex", 5);
        var p2 = new Player("Alex", 5);
        var p3 = p1;

        Console.WriteLine(p1 == p2); 
        Console.WriteLine(p1 == p3); 
        Console.WriteLine(p1.Equals(p2)); 
        
        Console.WriteLine("Exercise #4");
        var user = new User { Login = "admin" };
        user.Password = "12345";
        Console.WriteLine(user.CheckPassword("12345")); // true
        user.Password = ""; // Ошибка
        
        Console.WriteLine("Exercise #5");
        var pn1 = new Point(2, 3);
        var pn2 = pn1;

        pn2.Move(5, 5);

        pn1.Print();
    }
}
public class Book
{
     private string author;
     private string title;
     private int pages;
     
     public string Author { get => author; set => author = value; }
     public string Title { get => title; set => title = value; }
     public int Pages { get => pages; set => pages = value; }

     public void PrintInfo()
     {
         Console.WriteLine(title + " " + author + " " + pages);
     }

     public Book(string title, string author, int pages)
     {
         Author = author;
         Title = title;
         Pages = pages;
     }
     public Book()
     {
         Author = "Неизвестно";
         Title = "Неизвестно";
         Pages = 0;
     }

     public Book(string title)
     {
         Title = title;
         Author = "Неизвестно";
         Pages = 0;
     }
     public Book(string title, string author)
     {
         Author = author;
         Title = title;
         Pages = 0;
     }
}

public class Car
{
    private string brand;
    private string model;
    private float speed;
    
    public string Brand { get => brand; set => brand = value; }
    public string Model { get => model; set => model = value; }
    public float Speed { get => speed; set => speed = value; }

    public Car(string brand, string model)
    {
        Brand = brand;
        Speed = speed;
    }
    public Car() : this ("Неизвестно", "Неизвестно") { }
    public Car (string brand) : this(brand, "Неизвестно") { }
    
    public void Accelerate()
    {
        Speed += 10;
    }
}

public class Player
{
    private string name;
    private int level;
    
    public string Name { get => name; set => name = value; }
    public int Level { get => level; set => level = value; }

    public void PrintInfo()
    {
        Console.WriteLine(name + " " + level);
    }
    
    public Player(string name, int level) { Name = name; Level = level; }
}

public class User
{
    private string login;
    private string password;

    public string Login
    {
        get => login;
        set => login = value;
    }

    public string Password
    {
        get => password;
        set
        {
            if (value != "")
            {
                password = value;
                Console.WriteLine("Пароль обновлен");
            }
            else Console.WriteLine("Error");
        }
    }
    public bool CheckPassword(string input)
    {
        return password == input;
    }
}

public class Point
{
    private float x;
    private float y;
    
    public float X { get => x; set => x = value; }
    public float Y { get => y; set => y = value; }

    public void Move(int dx, int dy)
    {
        X = dx;
        Y = dy;
    }

    public void Print()
    {
        Console.WriteLine(X + " " + Y);
    }

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
}