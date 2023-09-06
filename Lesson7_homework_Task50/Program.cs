// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же 
//указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

bool IndexCheck(int i, int j, int[,] matrix)
{

    if (i <= matrix.GetLength(0) && j <= matrix.GetLength(1)) return true;

    else return false;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        //Console.WriteLine(" |");
        Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -10, 9);

Console.WriteLine("Задан массив");
PrintMatrix(array2d);

Console.WriteLine("Введите позицию строки i = ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию столбца j = ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 >= 0 && number2 >= 0)
{
    bool indexCheck = IndexCheck(number1, number2, array2d);

    if (indexCheck == true) Console.WriteLine($"Значение элемента {array2d[number1, number2]}");
    else Console.WriteLine("такого числа в массиве нет");
}
else Console.WriteLine("введены некорректные числа");





