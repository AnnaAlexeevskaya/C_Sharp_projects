// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 1 || number2 < 1)
{
    Console.WriteLine("Ошибка ввода!");
    return;
}

int NaturalNumbersSumMN(int num1, int num2)

{
    int sum = 0;
    if (num1 == num2) return num1; // если числа M и N равны, возвращаем это число, так как в промежутке 0 значений
    else if (num1 > num2)
    {

        return sum += num1 + NaturalNumbersSumMN(num1 - 1, num2);

    }

    else
    {
        return sum += num2 + NaturalNumbersSumMN(num1, num2 - 1);

    }

}

int sumMN = NaturalNumbersSumMN(number1, number2);
Console.WriteLine($"сумма элементов между M и N =  {sumMN}");