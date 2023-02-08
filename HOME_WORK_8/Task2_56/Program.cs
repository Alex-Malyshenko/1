/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else
            Console.WriteLine("You entered an incorrect number. Repeat the input");
    }

    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(-100, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindLineMinSum(int[,] matrix)
{

    Dictionary<int, int> Slovar = new Dictionary<int, int>();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumTemp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumTemp += matrix[i, j];
        }
        Slovar.Add(sumTemp, i);


    }
    Slovar.OrderBy(x => x.Key);

    return Slovar[Slovar.Keys.Min()];
}

int rows = GetNumber("Enter the number of rows: ");
int columns = GetNumber("Enter the number of columns: ");
int[,] matrix = InitMatrix(rows, columns);

Console.WriteLine();
Console.WriteLine("Generated matrix :");
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
int lineMinSum = FindLineMinSum(matrix);
Console.WriteLine($"In line {lineMinSum + 1}, the minimum sum of elements is. ");