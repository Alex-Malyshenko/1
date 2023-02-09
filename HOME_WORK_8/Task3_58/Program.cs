/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
            matrix[i, j] = rnd.Next(1, 5);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] MultiplicationMatrix(int [,] matrixA, int [,] matrixB)
{
    int [,] matrixC = new int [matrixA.GetLength(0), matrixB.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                sum = sum + matrixA[i, k]* matrixB[k, j];
            }
            matrixC[i, j] = sum;
            
        }
    }

    return matrixC;
}

int rows = GetNumber("Enter the number of rows matrix A: ");
int columns = GetNumber("Enter the number of columns matrix A(rows matrix B): ");
int columnsB = GetNumber("Enter the number of columns matrix B: ");


int[,] matrixA = InitMatrix(rows, columns);
int[,] matrixB = InitMatrix(columns, columnsB);

Console.WriteLine();
PrintMatrix(matrixA, "Matrix A");
Console.WriteLine();
PrintMatrix(matrixB, "Matrix B");
Console.WriteLine();

PrintMatrix(MultiplicationMatrix(matrixA, matrixB), "The resulting matrix(A x B):");
