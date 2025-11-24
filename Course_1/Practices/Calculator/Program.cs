using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an arithmetic expression");
        Console.WriteLine("in the format A + B ");
        
        string expression = Console.ReadLine();
        
        string[] parts = expression.Split(' ');

        int.TryParse(parts[0], out int num1);
        int.TryParse(parts[2], out int num2);
        
        string action = parts[1];
        int answer = 0;

        switch (action)
        {
            case "+":
                answer = num1 + num2;
                break;
            case "-":
                answer = num1 - num2;
                break;
            case "*":
                answer = num1 * num2;
                break;
            case "/":
                answer = num1 / num2;
                break;
        }
        
        Console.WriteLine($"answer = {num1} {action} {num2} = {answer}");
        Console.WriteLine("nishtyak");
    }
}