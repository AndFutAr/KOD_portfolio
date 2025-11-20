using System;         

class Program          
{
    static void Main()
    {
        int a = 12, b = 5;
        int sum, diff, multiplc, div, rem;
        sum = a + b;
        diff = a - b;
        multiplc = a * b;
        div = a / b;
        rem = a % b;
        Console.WriteLine("sum = " + sum + "; difference = " + diff
                          + "; multiplication = "+ multiplc + "; division = "+ div
                          + "; remainder from division = "+ rem);

        string name;
        Console.WriteLine("Напиши свое имя");
        name = Console.ReadLine();
        Console.WriteLine("Привет, " + name);

        int num;
        Console.WriteLine("Теперь введи число");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine(num + " * 19 = " + num * 19);
    }
}