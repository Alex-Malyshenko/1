/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumber(string message)
{
    int resultNumber = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!\n");
        }
    }
    return resultNumber;
}

int a = GetNumber("Введите число: ");
int b = GetNumber("Введите число: ");
Console.WriteLine($"Число {a} в натуральной степени {b} равно: {Math.Pow(a, b)}");