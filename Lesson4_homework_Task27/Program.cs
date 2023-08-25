// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumFigures(int num)
{
  int sumTotal = 0;
 

if (num == 0) return 0;
while ((num) !=0)
    {
    sumTotal = sumTotal+ num%10;
    num = num/10;
    }
return sumTotal;
}

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
 int result = SumFigures(number);
 Console.WriteLine($" сумма всех чисел {number}-> {result}");

