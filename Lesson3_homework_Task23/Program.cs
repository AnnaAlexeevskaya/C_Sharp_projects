// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void CubeN(int n)
{

int count = 1;
while (count <= n)
    {
    Console.WriteLine($"{count, 3} |-> {count*count*count, 5}; ");
    count++;    
    }
}


Console.WriteLine("Введите натуральное целое число");
Console.Write("N: ");
int n = Convert.ToInt32(Console.ReadLine());

CubeN(n);