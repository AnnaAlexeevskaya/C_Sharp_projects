// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)


int[,,] CreateArray3dRndInt(int rows, int columns, int depth, int min, int max)
{
    //                        0       1
    int[,,] matrix = new int[rows, columns, depth]; // rows = 3, columns = 4
    int[] dublicates = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);

                for (int l = 0; l < matrix.GetLength(0); l++)
                {
                    for (int m = 0; m < matrix.GetLength(1); m++)
                    {

                        for (int n = 0; n < matrix.GetLength(2); n++)
                        {
                            int z = 0;
                            if (matrix[i, j, k] ==matrix[l, m, n] && ((l!= i) && (j != m) && (n!= k)))
                            {

                                dublicates[z] = matrix[i, j, k];
                                Console.WriteLine($" t{dublicates[z]} ");
                                //matrix[i, j, k] = 0;        
                                z++;
                            }
                        }
                    }

                }


            }

        }

    }


    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],5} ({i},{j},{k})"); //
            }
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите размер 3-d массива: ");
Console.WriteLine("кол-во rows");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("кол-во columns");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("кол-во depth");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 * n2 * n3 > 99)
{
    Console.WriteLine("невозможно сформировать думерный массив из данных измерений");
    return;

}


int[,,] createArray3dRndInt = CreateArray3dRndInt(n1, n2, n3, 10, 98);
PrintMatrix(createArray3dRndInt);
