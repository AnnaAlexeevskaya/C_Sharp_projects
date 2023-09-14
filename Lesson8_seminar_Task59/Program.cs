// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    //                               
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

int[] MinElementIndexes(int[,] matrix)
{
    int minElemRow = 0;
    int maxElemCol = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < matrix[minElemRow, maxElemCol]) 
            {
                minElemRow = i;
                maxElemCol = j;

            }
        }
    }
    return new int[] {minElemRow, maxElemCol};

}

int[,] NewMatrixDeletedMinRowsCols(int[,] matrix, int delRow, int delCol)
{
int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
int m = 0, n = 0; //индексы исходной матрицы
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        n = 0;
        if (m == delRow) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
          if (n == delCol) n++;  

            newMatrix[i,j] = matrix[m,n];
            n++;
        }
        m++;
    }
    return newMatrix;
}



int[,] array2d = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
int[] minElementIndexes =  MinElementIndexes(array2d);
int[,] newMatrixDeletedMinRowsCols = NewMatrixDeletedMinRowsCols(array2d, minElementIndexes[0], minElementIndexes[1]);
PrintMatrix(newMatrixDeletedMinRowsCols);