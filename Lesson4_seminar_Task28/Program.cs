// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

int MultiplicityN(int n)
{
int mlt = 1;

checked
{
for(int i=1; i <= n; i++) mlt *=i;
}
return mlt;
}

int multiplicityN =  MultiplicityN(number);

Console.WriteLine($"Произведение чисел от 1 до {number} =  {multiplicityN}");

