// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



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


int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{

    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)


    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {

            for (int k = 0; k < matrix1.GetLength(1); k++)
            {

                matrix[i, j] += matrix1[i, k] * matrix2[k, j];

            }


        }

    }
    return matrix;
}

int[,] firstArray2d = CreateMatrixRndInt(2, 3, 1, 10);
Console.WriteLine("Матрица 1 ");
PrintMatrix(firstArray2d);

int[,] secondArray2d = CreateMatrixRndInt(3, 4, 1, 10);
Console.WriteLine();
Console.WriteLine("Матрица 2 ");
PrintMatrix(secondArray2d);

if (firstArray2d.GetLength(1) == secondArray2d.GetLength(0)) // проверка что матрицы можно перемножить: число столбцов 1ой матрицы равно числу столбцов 2ой матрицы
{
    int[,] matrixMultiplication = MatrixMultiplication(firstArray2d, secondArray2d);
    Console.WriteLine();
    Console.WriteLine("Матрица1 х Матрицу 2 : ");
    PrintMatrix(matrixMultiplication);
}

else Console.WriteLine("Умножение матриц невозможно");

