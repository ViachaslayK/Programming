
internal class Console_F
{
    private static void Main()
    {
        Console.WriteLine("В феврале {0} или {1} дней",28,29);
        Console.WriteLine("В феврале{0,3} или{1,3} дней", 28, 29);

        Console.WriteLine("Число\tКвадрат\tКуб\t");

        for (int i = 1; i < 10; i++)
            Console.WriteLine("{0}\t{1}\t{2}\t",i,i*i,i*i*i);
        Console.WriteLine("10/3 = {0:#.##}", 10.0 / 3.0);
    }
}