/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine(" Y = K1 * X + B1 and Y = K2 *X + B2 ");
Console.Write("Enter K1: ");
float number_K_One = float.Parse(Console.ReadLine());

Console.Write("Enter B1: ");
float number_B_One = float.Parse(Console.ReadLine());

Console.Write("Enter K2: ");
float number_K_Two = float.Parse(Console.ReadLine());

Console.Write("Enter B2: ");
float number_B_Two = float.Parse(Console.ReadLine());

float x = (number_B_Two - number_B_One) / (number_K_One - number_K_Two);

Console.WriteLine($"The X coordinate is equal to {x}");
Console.WriteLine($"The Y coordinate is equal to {number_K_One * x + number_B_One}");