using System;

class Program
{
    private static void Main()
    {
        Console.WriteLine("Exercise #1-2");
        var car = new Car { Brand = "BMW" };
        car.Accelerate();
        Console.WriteLine($"{car.Brand} едет со скоростью {car.Speed} км/ч");
        var car2 = new Car("Audi", 50);
        Console.WriteLine($"{car2.Brand} едет со скоростью {car2.Speed} км/ч");
        
        Console.WriteLine("Exercise #3-4");
        var lib = new Library();
        lib.AddBook(new Book("1984", "Дж. Оруэлл", 350));
        lib.PrintAllBooks();
        
        Console.WriteLine("Pro level #1");
        Calculator calc = new Calculator();
        calc.UseCalculator();
        
        Console.WriteLine("Pro level #2");
        var phone = new Phone { Model = "Samsung Galaxy" };

        phone.Charge(30);
        Console.WriteLine($"Заряд: {phone.Battery}%");

        phone.Use(10);
        Console.WriteLine($"Заряд: {phone.Battery}%");
    }
}

public class Car
{
    private string brand;
    private float speed;
    
    public string Brand { get => brand; set => brand = value; }
    public float Speed { get => speed; set => speed = value; }

    public Car(string brand, float speed)
    {
        Brand = brand;
        Speed = speed;
    }
    public Car() { Brand = ""; Speed = 0; }
    
    public void Accelerate()
    {
        Speed += 10;
    }
}

public class Book()
{
     private string author;
     private string title;
     private int pages;
     
     public string Author { get => author; set => author = value; }
     public string Title { get => title; set => title = value; }
     public int Pages { get => pages; set => pages = value; }

     public Book(string title, string author, int pages) : this()
     {
         Author = author;
         Title = title;
         Pages = pages;
     }

     public void Read(int yourPages)
     {
         if (yourPages > Pages) yourPages = Pages;
         Console.WriteLine($"Вы прочитали {yourPages} страниц из {Pages}");
     }
}

public class Library()
{
    private List<Book> books = new List<Book>();
    
    public void AddBook(Book book) => books.Add(book);

    public void PrintAllBooks()
    {
        foreach (Book book in books)
        {
            Console.WriteLine(book.Author + " " + book.Title);
        }
    }
}

public class Calculator
{
    private Expression currentExpression;

    public void UseCalculator()
    {
        string command = "";
        while (command != "exit")
        {
            command = WriteExpression();
        }
    }

    private string WriteExpression()
    {
        currentExpression = new Expression();
        string expression = Console.ReadLine();
        if (expression == "exit") return expression;
        currentExpression.WriteExpression(expression);

        float num1 = currentExpression.Num1();
        float num2 = currentExpression.Num2();
        string action = currentExpression.Action();
        float answer = 0;
        
        switch (action)
        {
            case "+":
                answer = AddFloat(num1, num2);
                break;
            case "-":
                answer = SubFloat(num1, num2);
                break;
            case "*":
                answer = MulFloat(num1, num2);
                break;
            case "/":
                answer = DivFloat(num1, num2);
                break;
        }

        currentExpression.SetAnswer(answer);
        Console.WriteLine(currentExpression.Answer());
        return expression;
    }
    //(Add, Subtract, Multiply, Divide).
    private float AddFloat(float x, float y) => x + y;
    private float SubFloat(float x, float y) => x - y;
    private float MulFloat(float x, float y) => x * y;
    private float DivFloat(float x, float y) => x / y;
}

public class Expression
{
    private float num1, num2;
    private string action;
    private float answer;

    public float Num1() => num1;
    public float Num2() => num2;
    public string Action() => action;

    public float Answer() => answer;
    public void SetAnswer(float value) => answer = value;

    public void WriteExpression(string expression)
    {
        string[] parts = expression.Split(' ');

        float.TryParse(parts[0], out num1);
        float.TryParse(parts[2], out num2);
        action = parts[1];
    }
}

public class Phone
{
    private string model;
    private int battery;
    
    public string Model { get => model; set => model = value; }
    public int Battery { get => battery; set => battery = value; }

    public void Charge(int amount)
    {
        if (Battery + amount > 100) Battery = 100;
        else Battery += amount;
    }

    public void Use(int amount)
    {
        if (Battery - amount < 0) Battery = 0;
        else Battery -= amount;
    }

    public Phone() { }
}