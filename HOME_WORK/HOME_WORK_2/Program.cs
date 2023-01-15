/* Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

double Max(double arg1, double arg2, double arg3)
{
    double result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


double[] array = {0, 0, 0};

Console.Write("Введите первое вещественное число: ");
double a = Convert.ToDouble(Console.ReadLine());
array[0] = a;

Console.Write("Введите второе вещественное число: ");
double b = Convert.ToDouble(Console.ReadLine());
array[1] = b;

Console.Write("Введите третье вещественное число: ");
double c = Convert.ToDouble(Console.ReadLine());
array[2] = c;

double max = Max(array[0], array[1], array[2]);

Console.WriteLine(max);