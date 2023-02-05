/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
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

void RezMatrix(int[,] matrix, int rows_index, int columns_index)
{
    if (rows_index > matrix.GetLength(0) || columns_index > matrix.GetLength(1))
    {
        Console.WriteLine("Элемент с такими индексами не существует!");
    }
    else
    {
        Console.WriteLine($"Искомый элемет : {matrix[rows_index, columns_index]}");
    }
}


int countOfRows = GetNumber("Введите количество строк:");
int countOfColums = GetNumber("Введите количество столбцов:");
int[,] matrix = InitMatrix(countOfRows, countOfColums);

PrintMatrix(matrix);

int rows_index = GetNumber("Введите индекс строки искомого элемента:");
int columns_index = GetNumber("Введите индекс столбца искомого элемента:");

RezMatrix(matrix, rows_index-1, columns_index-1);