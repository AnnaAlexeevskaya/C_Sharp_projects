// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите натуральное число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 1 || number2 < 0)
{
    Console.WriteLine("Ошибка ввода!");
    return;
}

int PowerAB (int a, int b)

{   if (b == 0) return 1;
    return  a*PowerAB(a, b-1); // в стек сохраняются значения аргументов рекурсии 

}

Console.Write("A в степени B = ");
Console.Write(PowerAB(number1, number2));