// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double [,] CreateMatrixRndDbl(int rows, int columns, int min, int max)
{                        
    double [,] matrix = new double[rows, columns]; 
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble()*(max-min) + min;
        }
    }
    return matrix;
}

//Печать 2-мерного массива

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       // Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 7:F1}  ");
        }
        //Console.WriteLine(" |");
        Console.WriteLine();
         }
}

double [,] array2d = CreateMatrixRndDbl(3, 4, -10, 10);
PrintMatrix(array2d);