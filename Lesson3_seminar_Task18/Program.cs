string QuarterN(int num) // x = 6, y = -7
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;
}

Console.WriteLine("Введите четверть");
Console.Write("Quarter: ");
int temp = Convert.ToInt32(Console.ReadLine());

string quarter = QuarterN(temp);

string result = quarter != null
                ? $"Указанная четверть соответствует координатам -> {quarter}" 
                : "Введена некорректная четверть";
Console.WriteLine(result);

