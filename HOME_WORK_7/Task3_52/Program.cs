/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
 в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
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
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FindArithmeticMean(int[,] matrix)
{
    float sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
    Console.Write($"{Math.Round(sum / matrix.GetLength(1), 2)}; ");
    sum = 0;
    }
}

int countOfRows = GetNumber("Введите количество строк:");
int countOfColums = GetNumber("Введите количество столбцов:");
int[,] matrix = InitMatrix(countOfRows, countOfColums);

PrintMatrix(matrix);
Console.WriteLine();
FindArithmeticMean(matrix);
