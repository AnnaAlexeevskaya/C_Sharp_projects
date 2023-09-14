// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{

    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}


int[] SumByRows(int[,] matrix)
{
    int[] sums = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sums[i] += matrix[i,j];
        }
        
    }

return sums;
}


int MinElementInArray(int[] arr)
{
    int minIndex = 0;
    int min = arr[0];
    for (int i = 1; i < arr.Length-1; i++)
    {
        if (arr[i] < min) 
        {
        min = arr[i];
        minIndex = i;
        }
    }
    return minIndex;
}


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


int[,] array2d = CreateMatrixRndInt(5, 5, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] sumByRows = SumByRows(array2d);
Console.Write("Сумма элементов в каждой строке равна ");
PrintArray(sumByRows);
int minElementInArray = MinElementInArray(sumByRows);
Console.WriteLine();
Console.WriteLine($"Индекс строки c наименьшей суммой элементов = {minElementInArray}");
