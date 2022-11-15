using System;

internal class Cout
{
    static void Main()
    {
        Cout1();
        Console.WriteLine("\n");
        Cout2();
        Console.WriteLine("Число 123 в 2-ой системе: ");
        Number_to_2sis();
        
    }

    static void Cout1()
    {
        ushort num=10;

        for (ushort i = 1;i<=10;i++)
        {
            num = i;
            Console.WriteLine("Num = "+num);

            num =(ushort) (num & 0xFFFE);
            Console.WriteLine("Четное число: "+num+"\n");
        }
        
    }

    static void Cout2()
    {
        ushort num=10;
        for (ushort i = 1; i <= 10; i++)
        {
            num = i;
            Console.WriteLine("Num = " + num);

            num = (ushort)(num | 1);
            Console.WriteLine("Нечетное число: " + num + "\n");
        }
    }

    static void Number_to_2sis()
    {
        byte val=123;

        for(int t=128;t>0;t=t/2)
        {
            if ((val & t) != 0) Console.Write("1 ");
            if ((val & t) == 0) Console.Write("0 ");
        }
    }
}