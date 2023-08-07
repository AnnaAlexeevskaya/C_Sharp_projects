// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Enter a number from 1 to 7");
int number = Convert.ToInt32(Console.ReadLine());


bool WeekendCheck(int num)

{

if (num == 6 | num == 7) return true;
else return false;
}

 bool weekendCheck = WeekendCheck(number);
 Console.WriteLine($"Entered number is a weekend?  -> {weekendCheck}");