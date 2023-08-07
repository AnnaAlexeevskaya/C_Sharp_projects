// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter 3-digit number");
int number = Convert.ToInt32(Console.ReadLine());


int ShowSecondDigit(int num)

{
return ((num % 100) / 10);
}

 int showSecondDigit = ShowSecondDigit(number);
 Console.WriteLine($"Second digit is -> {showSecondDigit}");