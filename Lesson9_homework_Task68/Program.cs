// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    пока n ≠ 0
//      если m = 0
//        m:= 1
//      иначе
//        m:= ack(n, m - 1)
//      n:= n - 1
//    вернуть m + 1

int Ack(int m, int n)
{
    while (m != 0)
    {
        if (n == 0) n = 1;
        else 
        {
        n = Ack(m, n - 1);
        }
        m--;
        
    }
    return n + 1;

}


Console.WriteLine("Введите натуральное число m: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число n: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0 || number2 < 0)
{
    Console.WriteLine("Ошибка ввода!");
    return;
}

int ackResult = Ack(number1, number2);

Console.WriteLine($" A(m,n) = {ackResult}");