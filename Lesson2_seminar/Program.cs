// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

 int number = new Random().Next(10, 100); // 99 + 1
 Console.WriteLine($"Randow 2-digit figure -> {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit>secondDigit) Console.WriteLine($"Bigger digit is -> {firstDigit}");
// else Console.WriteLine($"Bigger digit is -> {secondDigit}");


//тернарный оператор - аналог if но возвращает значение

//int MaxDigit = firstDigit > secondDigit ? firstDigit : secondDigit


//Solution with functions


int maxDigit = MaxDigit(number);
Console.WriteLine($"Bigger digit is -> {maxDigit}");

int MaxDigit(int num)

{
 int firstDigit = num / 10;
 int secondDigit = num % 10;

int result = firstDigit > secondDigit ? firstDigit : secondDigit;
return result;



}


