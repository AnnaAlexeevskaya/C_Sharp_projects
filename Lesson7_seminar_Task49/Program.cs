﻿int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    //                        0       1
    int[,] matrix = new int[rows, columns]; // rows = 3, columns = 4
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

void SearchEvenIndexRaplaceQuart(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i +=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j +=2)
        {
           // if(i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
            matrix[i, j] *= matrix[i, j];
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
SearchEvenIndexRaplaceQuart(array2d);
PrintMatrix(array2d);