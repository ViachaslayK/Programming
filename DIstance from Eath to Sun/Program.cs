using System;
class Inches
{
    static void Main()
    {
        long miles;
        long inches;

        miles = 93000000;
        inches = miles * 5280 * 12;

        Console.WriteLine("Расстояние до Солнце: " + inches + " в дюймах.");
    }
}