/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

*/
int GetNumber(string message)
{
    int result =0;

    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else
            Console.WriteLine("You entered an incorrect number. Repeat the input"); 
    }

    return result;
}

int [,] InitMatrix(int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)
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

int [,] SortLineMatrix(int [,] matrix)
{
    int [] matrixTemp = new int [matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixTemp[j] = matrix[i,j];
        }
        
        Array.Sort(matrixTemp);
        Array.Reverse(matrixTemp);
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i,j] = matrixTemp[j];
        }

    }
    return matrix;
}


int rows = GetNumber("Enter the number of rows: ");
int columns = GetNumber("Enter the number of columns: ");
int [,] matrix = InitMatrix(rows, columns);

Console.WriteLine();
Console.WriteLine("Generated matrix :");
Console.WriteLine();
PrintMatrix(matrix);

SortLineMatrix(matrix);

Console.WriteLine();
Console.WriteLine("A matrix with row elements sorted in reverse order:");
Console.WriteLine();
PrintMatrix(matrix);