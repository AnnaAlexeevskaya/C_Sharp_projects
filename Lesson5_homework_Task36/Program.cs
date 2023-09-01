// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int SumOfOddElements(int[] arr) // поиск суммы нечетных элементов

{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }

    return sum;

}

 void PrintArray(int[] arr)  // вывод массива
 {
     Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


int[] createArrayRndInt = CreateArrayRndInt(6, 1, 20);
int sumOfOddElements = SumOfOddElements(createArrayRndInt);
PrintArray(createArrayRndInt);
Console.WriteLine($"Сумма нечетных элементов массива равна {sumOfOddElements}");
