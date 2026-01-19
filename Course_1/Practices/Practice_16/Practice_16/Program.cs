using System;
using System.Collections.Generic;

namespace Practice_16
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine("Exercise #1");
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(2));
            shapes.Add(new Rectangle(4, 3));
            shapes.Add(new Rectangle(5.5, 7));
            foreach (Shape shape in shapes)
                shape.Print();
            
            Console.WriteLine("Exercise #2");
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("Рекс"));
            animals.Add(new Cat("Мурка"));
            foreach (Animal animal in animals)
            {
                animal.Eat();
                animal.MakeSound();
            }
            
            Console.WriteLine("Exercise #3");
            Transport[] t = { new Car(), new Boat() };
            foreach (var x in t) x.Move();
            
            Console.WriteLine("Exercise #4");
            DocumentExporter[] exporters =
            {
                new TxtExporter(),
                new PdfExporter()
            };

            foreach (var e in exporters)
            {
                e.ShowInfo("Hello world!");
                e.Export("Hello world!");
            }
        }
    }

    public abstract class Shape
    {
        public abstract string Name { get; }

        public abstract double GetArea();

        public void Print()
        {
            Console.WriteLine(Name + ": площадь = " + GetArea());
        }
    }
    public class Circle : Shape
    {
        public override string Name => "Circle";

        private double area;
        public override double GetArea() => area;

        public Circle(double radius)
        {
            area = 3.14 * radius * radius;
        }
    }
    public class Rectangle : Shape
    {
        public override string Name => "Rectangle";

        private double area;
        public override double GetArea() => area;

        public Rectangle(double Width, double Height)
        {
            area = Width * Height;
        }
    }

    public abstract class Animal
    {
        public string Name;
        
        protected Animal(string name)
        {
            Name = name;
            Console.WriteLine( "Создано животное: " + Name);
        }

        public void Eat() => Console.WriteLine(Name + " ест");
        public abstract void MakeSound();
    }
    public class Dog : Animal
    {
        public Dog(string Name) : base(Name) { }
        public override void MakeSound() => Console.WriteLine(Name + ": Гав-Гав!");
    }
    public class Cat : Animal
    {
        public Cat(string Name) : base(Name) { }
        public override void MakeSound() => Console.WriteLine(Name + ": Мяу!");
    }

    public abstract class Transport
    {
        public void Move() 
        {
            Start();
            MoveCore(); 
            Stop();
        }

        protected void Start() => Console.WriteLine("Старт");
        protected abstract void MoveCore();
        protected void Stop() => Console.WriteLine("Стоп");
    }
    public class Car : Transport
    {
        protected override void MoveCore() => Console.WriteLine("Машина едет по дороге");
    }
    public class Boat : Transport
    {
        protected override void MoveCore() => Console.WriteLine("Лодка плывёт по воде");
    }

    public abstract class DocumentExporter
    {
        protected abstract string FormatName();
        public abstract void Export(string content);

        public void ShowInfo(string content)
            => Console.WriteLine("Экспорт в формат " + FormatName() + ": " + content);
    }
    public class TxtExporter : DocumentExporter
    {
        protected override string FormatName() => "TXT";
        
        public override void Export(string content)
            => Console.WriteLine("Сохраняем текстовый файл");
    }
    public class PdfExporter : DocumentExporter
    {
        protected override string FormatName() => "PDF";
        
        public override void Export(string content)
            => Console.WriteLine("Создаём PDF-документ");
    }
}