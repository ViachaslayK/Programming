class Desimal
{
    static void Main()
    {
        decimal amount=1000.0M;//Дает более точный подчет числе с плавающей запятой.Добавлять букву M обязательно.
        const decimal rate_of_return= 0.07M;
        int years = 10;

        Console.WriteLine("Первоначальные вожения: " + amount);
        Console.WriteLine("Норма прибыли: " + rate_of_return);
        Console.WriteLine("В течение " + years+"лет");
        for (int i = 0; i < years; i++)
            amount=amount+(amount*rate_of_return);
        Console.WriteLine("Будущая сотимость равна $" + amount);
    }
}