// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

//объявление массива

// int[] array =  new int[8]; // по умолчанию массив заполнен нулями
// int[] array1 = {43, 55, 67, 55, 345}; // массив с конкретными значениями
// int[] array2 =  new int[3]{1,2,3};
// int[] array3 =new int []{43, 55, 67, 55, 345}; // массив с конкретными значениями

// объяснение на уроке

// int[] array = new int[8]; // 0 1 2 3 4 5 6 7

// int[] array2 = new int[]{43, 54, 66, 3, -55, 5, 53, 6};
// int[] array3 = new int[12]{43, 54, 66, 3, -55, 5, 53, 6, 54, 4, 23, 34};
// int[] array1 = {43, 54, 66, 3, -55, 5, 53, 6};

// array[0] = 465;
// array[7] = 23;
// //array[12] = 76;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i * i;
//     Console.Write(array[i] + " ");
// }






void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(2);
   
    }

}

void PrintArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write(arr1[i] + " ");
    }
}

int[] array =  new int[8];

FillArray(array);
PrintArray(array);


//решение в классе

// void FillArray(int[] array)
// {
//     Random rnd = new Random();

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(2);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int[] arr = new int[8];

// FillArray(arr);
// PrintArray(arr);