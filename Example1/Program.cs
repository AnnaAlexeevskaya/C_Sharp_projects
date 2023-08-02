// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Task 1

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int square = number * number;
// Console.WriteLine($"Квадрат числа {number} = {square}");

// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


// Console.WriteLine("проверка на квадрат числа ");
// Console.Write("Введите число 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 == number2*number2)

// {
// Console.WriteLine("да:1ое число является квадратом 2го числа");
// }
// else
// {
//  Console.WriteLine("нет:1ое число не является квадратом 2го числа");   
// }

Console.WriteLine("Вывод дня недели");
Console.Write("Введите число от 1 до 7: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number3 == 1)

{
    Console.WriteLine("1ий день - понедельник");
}

else if (number3 == 2)

{
    Console.WriteLine("2ой день - вторник");
}

else if (number3 == 3)

{
    Console.WriteLine("3ий день - среда");
}

else if (number3 == 4)

{
    Console.WriteLine("4ый день - четверг");
}

else if (number3 == 5)

{
    Console.WriteLine("5ый день - пятница");

}
else if (number3 == 5)

{
    Console.WriteLine("5ый день - пятница");

}

else if (number3 == 6)

{
    Console.WriteLine("6ой день - суббота");

}

else if (number3 == 7)

{
    Console.WriteLine("7ой день - воскресение");

}

else

{
    Console.WriteLine("не знаю такой день недели");
}







