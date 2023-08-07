// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());


int ShowThirdDigit(int num)

{

while (num > 999)
{
num = num /10;
}

return (num % 10);
}

 int showThirdDigit = ShowThirdDigit(number);
 Console.WriteLine($"Third digit is -> {showThirdDigit}");