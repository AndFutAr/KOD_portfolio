using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Exercise #1");
        int number = 10;
        if (number > 0)
            Console.WriteLine("Число положительное");
        else if (number < 0)
            Console.WriteLine("Число отрицательное");
        else
            Console.WriteLine("Число равно нулю");
        
        Console.WriteLine("Exercise #2");
        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age >= 18)
            Console.WriteLine("Вы совершеннолетний");
        else
            Console.WriteLine("Вы несовершеннолетний");
        
        Console.WriteLine("Exercise #3");
        int number2 = 7;
        if (number2 % 2 == 0)
            Console.WriteLine("Число чётное");
        else
            Console.WriteLine("Число нечётное");
        
        Console.WriteLine("Exercise #4");
        int a = 5, b = -2;
        if (a > 0 && b > 0)
            Console.WriteLine("Оба числа положительные");
        if (a > 0 || b > 0)
            Console.WriteLine("Хотя бы одно число положительное");
        if (a <= 0)
            Console.WriteLine("a не положительное");
        
        Console.WriteLine("Exercise #5");
        Console.WriteLine("Enter your grade");
        int grade = int.Parse(Console.ReadLine());
        if (grade < 3) Console.WriteLine("Неудовлетворительно");
        else if (grade == 3) Console.WriteLine("Удовлетворительно");
        else if (grade == 4) Console.WriteLine("Хорошо");
        else if (grade == 5) Console.WriteLine("Отлично");
        
        Console.WriteLine("Exercise #6");
        Console.WriteLine("Enter 3 nums one by one");
        int n1, n2, n3;
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        if (n1 > n2 && n1 > n3)
            Console.WriteLine(n1);
        else if (n2 > n3 && n2 > n1)
            Console.WriteLine(n2);
        else if (n3 > n1 && n3 > n2)
            Console.WriteLine(n3);

        Console.WriteLine("Exercise #7");
        Console.WriteLine("Enter your espession");
        float result;
        float num1 = int.Parse(Console.ReadLine());
        float num2 = int.Parse(Console.ReadLine());
        char action = char.Parse(Console.ReadLine());
        switch (action)
        {
            case '+': result = num1 + num2; break;
            case '-': result = num1 - num2; break;
            case '*': result = num1 * num2; break;
            case '/': result = num1 / num2; break;
            default: Console.WriteLine("wrong operator"); return;
        }
        Console.WriteLine($"answer = {num1} {action} {num2} = {result}");
    }
}