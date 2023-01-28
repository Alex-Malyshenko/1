/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int QuantityNumbers(int[] Array)
{
    int flag = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
            flag++;

    }
    return flag;
}

Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
Console.WriteLine(string.Join(",", array));
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве равно : {QuantityNumbers(array)}");
