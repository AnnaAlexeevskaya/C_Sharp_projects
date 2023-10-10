// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
//коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



// Create inital array

string[] FillArray(int count)
{

    Console.WriteLine($"Введите по порядку строки вмследующем количестве: {count}  ");

    string[] initArr = new string[count];

    for (int i = 0; i < count; i++)
    {
    
    initArr[i] = Console.ReadLine() ?? "Строка не введена";;

    }

return initArr;
}   


// Create new array with lelements = < 3 symbols

string[] ArrayTransformation(string[] initArr)

{
    string[] finArr = new string[initArr.Length];
    int j = 0;
    
    for (int i = 0; i < initArr.Length; i++)
    {
        
        if (initArr[i].Length <= 3) 
        {          
            finArr[j] = initArr[i];
            j++;
        }
        
    }
    
    return finArr;

}

void PrintArray(string[] finArr)
{
    Console.WriteLine("Новый массив с элементами длиной = < 3");
    Console.Write("[");
    for (int i = 0; i < finArr.Length; i++)
    {
        if (!String.IsNullOrEmpty(finArr[i]))
        {
            Console.Write(" " + finArr[i]);
        }
    }

    Console.Write("]");
}




Console.WriteLine("Введите кол-во элементов в массиве > 0");
int number = Convert.ToInt32(Console.ReadLine());

string[] fillArray = FillArray(number);
string[] arrayTransformation = ArrayTransformation(fillArray);
PrintArray(arrayTransformation);