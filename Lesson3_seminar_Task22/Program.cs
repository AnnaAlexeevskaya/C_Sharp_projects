// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

// void функция ничего не возвращает

void SquareN(int n)
{

int count = 1;
while (count <= n)
    {
    Console.Write($"{count} -> {count*count}; ");
    count++;    
    }
}


Console.WriteLine("Введите натуральное целое число");
Console.Write("N: ");
int n = Convert.ToInt32(Console.ReadLine());

SquareN(n);


//решение в классе  

// void TableSquare(int num)
// {
//     int count = 1;
//     while(count <= num)
//     {
//         Console.WriteLine($"{count, 3} -> {count*count, 5}");
//         count++;
//     }
// }

// Console.WriteLine("Введите натуральное число:");
// int number = Convert.ToInt32(Console.ReadLine());

// TableSquare(number);
