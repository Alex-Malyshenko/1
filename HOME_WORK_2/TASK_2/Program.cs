/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 99 && -99 < number)
{
    Console.WriteLine($" У данного числа нет третьей цифры!");
}
else
{
    string number_str = Convert.ToString(number);
    if (number < 0)
    {
        Console.WriteLine($"Третья цифра числа {number} это : {number_str[3]}");
    }

    else
    {
        Console.WriteLine($"Третья цифра числа {number} это : {number_str[2]}");
    }
}
