// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PowerAB(int a_temp, int b_temp)
{

int pwr = Convert.ToInt32(Math.Pow(a_temp,b_temp));
return pwr;
}

Console.WriteLine("Введите натуральное число 1:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число 2:");
int b = Convert.ToInt32(Console.ReadLine());

int powerAB = PowerAB(a,b);
Console.WriteLine($"Число {a} в степени {b} ->  {powerAB}");