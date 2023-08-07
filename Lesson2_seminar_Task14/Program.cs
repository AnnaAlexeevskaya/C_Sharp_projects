// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
int parameter1 = 7;

int parameter2 =23;

bool MultiplicityCheck(int num, int mult1, int mult2)

{

return num % mult1 == 0 && num % mult2 == 0;
 
}

 bool figuresCheck = MultiplicityCheck(number, parameter1, parameter2);
 Console.WriteLine($"Result is -> {figuresCheck}");