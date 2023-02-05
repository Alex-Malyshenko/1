/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/


int GetNumber(string message)
{
    int result = 0;
    Console.WriteLine(message);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели некорректное число. Повторите ввод!");
        }
    }

    return result;
}

double[,] InitMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rnd.NextDouble() * rnd.Next(-100, 100);
        }
    }

    return matrix;

}

void PrintMatrix(double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matrix[i,j], 2)}  ");
        }
        Console.WriteLine();
    }
}

int countOfRows = GetNumber("Введите количество строк:");
int countOfColums = GetNumber("Введите количество столбцов:");
double[,] matrix = InitMatrix(countOfRows, countOfColums);

PrintMatrix(matrix);

