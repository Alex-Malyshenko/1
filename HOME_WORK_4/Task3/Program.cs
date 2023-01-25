/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}");
        if (position != count - 1)
        {
            Console.Write(", ");
        }
        position++;
    }

}

Console.WriteLine("Введите размерность массива:");
int len = Convert.ToInt16(Console.ReadLine());

int[] array = new int[len];

FillArray(array);

Console.Write("Массив: [");
PrintArray(array);
Console.Write("]");