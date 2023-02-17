using System;
class Program
{
    static void Main()
    {
       Console.WriteLine("Hello, World!");
       Variable();
       Circle();
    }
    static void Variable()
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

    static void Converting()
    {
        int age1 = 10;
        string name = "20";
        age1 = Convert.ToInt32(name);
        Console.WriteLine(age1);
    }
}