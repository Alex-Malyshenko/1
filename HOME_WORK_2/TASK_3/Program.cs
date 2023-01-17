/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифровое обозначение дня недели(1, 2, 3, 4, 5, 6 , 7): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || 7 < number)
{
    Console.WriteLine($"Такого дня недели нет!");
}
else
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine($"Это выходной день! :)");
    }

    else
    {
        Console.WriteLine("Это будний день! :(");
    }
}
