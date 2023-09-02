// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] EnterNumbers(int m)

{

    int[] arr = new int[m];

    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите число номер {i + 1}");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;

}

int NumbersCount(int[] newArr)
{
    int count = 0;
    for (int i = 0; i < newArr.Length; i++)
    {
        if (newArr[i] > 0) count++;

    }

    return count;

}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


Console.WriteLine("Сколько чисел вы хотите ввести?");
int number = Convert.ToInt32(Console.ReadLine());
int[] enterNumbers = EnterNumbers(number);
PrintArray(enterNumbers);
int numbersCount = NumbersCount(enterNumbers);
Console.WriteLine($"Кол-во элекментов больше 0 = {numbersCount}");

