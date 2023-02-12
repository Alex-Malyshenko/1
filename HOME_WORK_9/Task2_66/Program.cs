/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

int GetNumber(string message)
{
    int result =0;

    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else
            Console.WriteLine("Вы ввелин не корректное число. Повторите ввод"); 
    }

    return result;
}

int SumNumbers(int a, int b)
{
    int sum = 0;
    while (a <= b) 
    {
        sum += a;
        a++;
        SumNumbers(a,b);
    }
    
    return sum;
}

Console.WriteLine();
int a = GetNumber("Введите натуральное число: ");
int b = GetNumber("Введите натуральное число: ");

Console.WriteLine($"Сумма чисел от {a} до {b} равна: {SumNumbers(a,b)}");

