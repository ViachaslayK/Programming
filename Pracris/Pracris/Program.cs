int Enter = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Enter);



int num;
int nextdigit;

num = 2794;

Console.WriteLine("Число: " + num);

Console.Write("Число в обратном порядке: ");

do
{
    nextdigit = num % 10;
    Console.Write(nextdigit);
    num = num / 10;
}while(num > 0);
Console.WriteLine();
Console.ReadKey();