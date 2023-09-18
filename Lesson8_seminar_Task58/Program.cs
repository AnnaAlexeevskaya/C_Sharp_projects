


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

int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int k = 0; // счетчик одномерного массива
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k++] = matrix[i, j];
        }

    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


void DictionaryFrequency(int[] arr)
{
    int count = 1;
    int num = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num) count++;
        else 
        {   
            Console.WriteLine($"Кол-во элементов {num} -> {count}");
            num = arr[i];
            count = 1;
        }

    }
    Console.WriteLine($"Кол-во элементов {num} -> {count}");
}




int[,] array2d = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2d);
int[] array = MatrixToArray(array2d);
Array.Sort(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
DictionaryFrequency(array);

