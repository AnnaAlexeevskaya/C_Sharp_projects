﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D (int x1, int y1, int z1, int x2, int y2, int z2)
{
    int side1 = (x1-x2);
    int side2 = (y1-y2);
    int side3 = (z1-z2);
    double distance3D =  Math.Sqrt(side1 * side1 + side2 * side2 + side3*side3);
    return distance3D;  

}

// координаты 1ой точки

Console.WriteLine("Введите координаты 1ой точки");
Console.Write("x1: ");
int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int yCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int zCoordinate1 = Convert.ToInt32(Console.ReadLine());

// координаты 2ой точки

Console.WriteLine("Введите координаты 2ой точки");
Console.Write("x2: ");
int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int yCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int zCoordinate2 = Convert.ToInt32(Console.ReadLine());


double result = Distance3D(xCoordinate1,yCoordinate1,zCoordinate1, xCoordinate2, yCoordinate2, yCoordinate2);

double resultRound = Math.Round(result, 2, MidpointRounding.ToZero); 

Console.WriteLine($"A ({xCoordinate1},{yCoordinate1},{zCoordinate1}); B ({xCoordinate2},{yCoordinate2},{zCoordinate2}) -> {resultRound}");

