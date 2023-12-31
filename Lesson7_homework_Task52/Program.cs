﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" ");
    }
}

double[] MatrixMeanByColumn(int[,] matrix)
{
 int columnSum;
 double[] meanArray = new double[matrix.GetLength(1)];
 for (int j = 0; j < matrix.GetLength(1); j++)
    {
        columnSum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           columnSum += matrix[i,j]; 
        }
        meanArray[j] = (double) columnSum/ (double) matrix.GetLength(0);
    }
   
   return meanArray;
}

void PrintArrayDouble(double[] arr)  // вывод на экран массива вещественных чисел
{
    Console.Write("");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.WriteLine(" ");
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2d);

 double[] matrixMeanByColumn = MatrixMeanByColumn(array2d);
 Console.Write("Среднее арифметическое каждого столбца ");
 PrintArrayDouble(matrixMeanByColumn);