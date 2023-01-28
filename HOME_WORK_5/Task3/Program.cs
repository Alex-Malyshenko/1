/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/


double[] CreateArray(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * rnd.Next(1,100), 3);
    }
    return arr;
}


Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(size);
Console.WriteLine(string.Join(",  ", array));
Console.WriteLine();
Console.WriteLine($"Разница между максимальным {array.Max()} и минимальным {array.Min()} элементами массива равна: {Math.Round(array.Max() - array.Min(), 3)}");
