// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Enter 1st number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd number");
int number2 = Convert.ToInt32(Console.ReadLine());

int FiguresCheck(int num1, int num2)

{
return num1 % num2;
 
}

 int figuresCheck = FiguresCheck(number1, number2);
 Console.WriteLine($"Result is -> {figuresCheck}");