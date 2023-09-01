// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)  // создание массива
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;

}

int CountOfEvenElements(int[] arr) // поиск количества четных элементов

{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }

    return count;

}

void PrintArray(int[] arr)  // вывод массива
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


int[] createArrayRndInt = CreateArrayRndInt(4, 1, 999);
int countOfEvenElements = CountOfEvenElements(createArrayRndInt);
PrintArray(createArrayRndInt);
Console.WriteLine($"Количество четных чисел в массиве равно {countOfEvenElements}");