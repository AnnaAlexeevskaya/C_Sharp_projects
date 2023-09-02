// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите параметры 1го уравнения: b1");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите параметры 1го уравнения: k1");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите параметры 2го уравнения: b2");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите параметры 2го уравнения: k2");
int k2 = Convert.ToInt32(Console.ReadLine());

double[] EquationSolution(int b_1, int k_1, int b_2, int k_2)
{

    double[] sol = new double[2];

    sol[1] =  ((double)b_2 - (double)b_1 * (double)k_2 / (double)k_1) / (1 - (double)k_2 / (double)k_1); // y
    sol[0] = (sol[1] - (double)b_1) / (double)k_1; //x

    return sol;

}

double[] equationSolution = EquationSolution(b1, k1, b2, k2);

Console.WriteLine($"точка пересечения ({equationSolution[0]:F1}, {equationSolution[1]:F1})");


