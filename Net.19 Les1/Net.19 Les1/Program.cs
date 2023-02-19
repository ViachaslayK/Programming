string[] Weeks =new string[7] {"Mondey", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
int W =Convert.ToInt32(DateTime.Now.DayOfWeek);
if (W == 0)
    W = 7;
for (int i=0;i<W;i++)
{
    Console.WriteLine(Weeks[i]);
}

var user = new User();

public class User
{

}
