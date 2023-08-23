// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool PalidromCheck(int d)
{
int a1 =  d / 10000;
int a2 =  (d / 1000)%10;
int a4 = (d % 100)/10;
int a5 = d % 10;

if (a1 == a5 && a2 == a4) return true;
return false;
}

Console.Write("Введите 5-значное целое число: ");
int digit = Convert.ToInt32(Console.ReadLine());

bool palidromCheck = PalidromCheck(digit);

if (palidromCheck == true) Console.Write($"{digit} -> да");
else Console.Write($"{digit} -> нет");
