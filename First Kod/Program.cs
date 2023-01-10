using System;
class Program
{
    static void Main()
    {
        short age= 32;
        string name = "Slava";
       Console.WriteLine("Hello, World!");
       Console.WriteLine($"Hello, my name is {name} my age is {age}");//Это называется интерпаляция

       variable();
       Circle();
    }
    static void variable()
    {
        int x;
        int y;
        x = 100;
        Console.WriteLine("x = " + x);
        y = x / 2;
        Console.Write("y = ");
        Console.WriteLine(y);
        
    }

    static void Circle()
    {
        double radius = 5;
        double area;

        area = radius * radius * 3.1415;

        Console.WriteLine("Площать круга = " + area);

    }
}