// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


 int number = new Random().Next(100, 1000); 
 Console.WriteLine($"Randow 3-digit figure -> {number}");

//  int maxDigit = MaxDigit(number);
// Console.WriteLine($"Bigger digit is -> {maxDigit}");

int DeletedFigure(int num)

{
 int firstDigit = num / 100;
 int secondDigit = num % 10;
 int result = firstDigit*10 + secondDigit;

return result;
}
int deletedFigure = DeletedFigure(number);
Console.WriteLine($"New figure is -> {deletedFigure}");
