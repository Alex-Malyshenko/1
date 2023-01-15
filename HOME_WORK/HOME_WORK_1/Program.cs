/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое вещественное число: ");
double numberOne = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе вещественное число: ");
double numberTwo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();


if (numberOne > numberTwo)
{
    Console.WriteLine($"Число {numberOne} больше числа {numberTwo}");
}
else
{
    Console.WriteLine($"Число {numberTwo} больше числа {numberOne}");
}