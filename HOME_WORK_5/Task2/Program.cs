/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;
}

int QuantityNumbers(int[] Array)
{
    int sum = 0;
    for (int i = 1; i < Array.Length; i+=2)
        sum+= Array[i];
    return sum;
}

Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
Console.WriteLine(string.Join(",", array));
Console.WriteLine();
Console.WriteLine($"Сумма элементов расположенных на нечётных позициях равна : {QuantityNumbers(array)}");
