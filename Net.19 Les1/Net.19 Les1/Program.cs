string[] Weeks =new string[7] {"Mondey", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
var W =Convert.ToInt32(DateTime.Now.DayOfWeek);
for (int i=0;i<=W-1;i++)
{
    Console.WriteLine(Weeks[i]);
}

