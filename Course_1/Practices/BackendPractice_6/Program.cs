using System;         

class Program          
{
    static void Main()
    {
        Console.Write("Exercise #1");
        int a1 = 12, b1 = 5;
        int sum1, diff1, multiplc1, div1, rem1;
        sum1 = a1 + b1;
        diff1 = a1 - b1;
        multiplc1 = a1 * b1;
        div1 = a1 / b1;
        rem1 = a1 % b1;
        Console.WriteLine("sum = " + sum1 +
                          "; difference = " + diff1 + 
                          "; multiplication = " + multiplc1 + 
                          "; division = " + div1 + 
                          "; remainder from division = " + rem1);

        Console.Write("Exercise #2");
        string name;
        Console.WriteLine("Напиши свое имя");
        name = Console.ReadLine();
        Console.WriteLine("Привет, " + name);

        int num;
        Console.WriteLine("Теперь введи число");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine(num + " * 19 = " + num * 19);
        
        Console.WriteLine("Exercise #3");
        Console.WriteLine("Write number a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Write number b:");
        int b = int.Parse(Console.ReadLine());
        int c = a + b;
        Console.WriteLine(a + " + " + b + " = " + c);
        
        Console.WriteLine("Exercise #4");
        Console.WriteLine("Write length:");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Write width:");
        int width = int.Parse(Console.ReadLine());
        int s = length * width;
        Console.WriteLine("s = " + length + " * " + width + " = " + s);
        
        Console.WriteLine("Exercise #5");
        Console.WriteLine("Enter the temperature in degrees Celsius");
        float c_temp = float.Parse(Console.ReadLine()); 
        float f_temp = c_temp * 1.8f + 32;
        Console.WriteLine("Temperature in Fahrenheit = " + c_temp + " * 1.8  + 32  = " + f_temp);
        
        Console.WriteLine("Exercise #6");
        Console.WriteLine("Enter 3 numbers one by one");
        float num_1 = float.Parse(Console.ReadLine());
        float num_2 = float.Parse(Console.ReadLine());
        float num_3 = float.Parse(Console.ReadLine());
        float MidNum = (num_1 + num_2 + num_3) / 3;
        Console.WriteLine("Arithmetic mean = (" + num_1 + " + " + num_2 + " + " + num_3 + ") / 3 = " + MidNum);
        
        Console.WriteLine("Exercise #7");
        Console.WriteLine("Enter 2 numbers one by one");
        float number_1 = float.Parse(Console.ReadLine());
        float number_2 = float.Parse(Console.ReadLine());
        float sum = number_1 + number_2;
        Console.WriteLine("Sum = " + number_1 + " + " + number_2 + " = " + sum);
        float diff = number_1 - number_2;
        Console.WriteLine("Difference = " + number_1 + " - " + number_2 + " = " + diff);
        float multiplc = a * b;
        Console.WriteLine("Multiplication = " + a + " * " + b + " = " + multiplc);
        float div = a / b;
        Console.WriteLine("Division = " + a + " / " + b + " = " + div);
        
        Console.WriteLine("Exercise #8");
        Console.WriteLine("Enter your amount of rubles");
        float rubles = float.Parse(Console.ReadLine());
        float dollars = rubles / 78.5f;
        float euros = rubles / 90.46f;
        float yuan = rubles / 11.05f;
        Console.WriteLine("Rubles = " + rubles);
        Console.WriteLine("Dollars = " + rubles + " / 78.5 = " + dollars);
        Console.WriteLine("Euros = " + rubles + " / 90.46 = " + euros);
        Console.WriteLine("Yuan = " + rubles + " / 11.05 = " + yuan);
    }
}