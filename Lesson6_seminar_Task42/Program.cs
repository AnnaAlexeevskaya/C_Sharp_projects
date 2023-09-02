// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int DecimalToBin(int num)
{
    int res = 0;
    int i = 1;
    while (num > 0)
    {
        res = res + (num % 2) * i;
        num  /= 2;  // число делим на свое основание
        i *= 10;  // разряд числа
    }
    return res;
}

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int decimalToBin = DecimalToBin(number);
Console.WriteLine(decimalToBin);