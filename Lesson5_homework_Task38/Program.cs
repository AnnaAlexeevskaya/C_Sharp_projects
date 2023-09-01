// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)  //создание массива вещественных чисел
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr; 
}

void PrintArrayDouble(double[] arr)  // вывод на экран массива вещественных чисел
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.WriteLine("]");
}

double MaxMinDifferenceArrayDouble(double[] arr)  // поиск максимального, минимального значения и их разницы
{
    double min_t = arr[0];
    double max_t = arr[0];
 for (int i = 1; i < arr.Length; i++)
 {
 if (arr[i] > max_t) max_t = arr[i];
 if (arr[i] < min_t) min_t = arr[i];
 }

 return (max_t-min_t);

}

double[] createArrayRndDouble  = CreateArrayRndDouble(5,1,15);
PrintArrayDouble(createArrayRndDouble);
double maxMinDifferenceArrayDouble = MaxMinDifferenceArrayDouble(createArrayRndDouble);
Console.WriteLine($"Разница между максимальным и минимальным значением в массиве = {maxMinDifferenceArrayDouble:F1}");