/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
using System.Linq;

int[,,] array = new int[2, 2, 2];

int[] InitListNumbers(int dimension)

{
    HashSet<int> numbers = new HashSet<int>();
    int[] listNum = new int[dimension];
    Random rnd = new Random();

    while (numbers.Count < dimension)
    {
         numbers.Add(rnd.Next(10, 100));
    }
   
    int i = 0;
    foreach (int j in numbers)
    {
        listNum[i] = j;
        i++;
    }
  
    return listNum;
}



void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void InitArray(int[,,] array, int[] listNumbers)
{
    int p = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += listNumbers[p];
                p++;
            }
        }
    }
}



int[] listNumbers = InitListNumbers(8);
InitArray(array, listNumbers);
PrintArray(array);
Console.WriteLine();

