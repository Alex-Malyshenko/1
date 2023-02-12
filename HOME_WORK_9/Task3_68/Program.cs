/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

uint GetNumber(string message)
{
    uint result =0;

    while (true)
    {
        Console.WriteLine(message);

        if(uint.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else
            Console.WriteLine("Вы ввелин не корректное число. Повторите ввод"); 
    }

    return result;
}

static uint functionAkkerman(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return functionAkkerman(n - 1, 1);
    else
      return functionAkkerman(n - 1, functionAkkerman(n, m - 1));
}

Console.WriteLine();
uint a = GetNumber("Введите начало диапазона(натуральное неотрицательное число): ");
uint b = GetNumber("Введите конец диапазона(натуральное неотрицательное число) : ");

Console.WriteLine($"Результа вычисления функции Аккермана от {a} до {b} равна: {functionAkkerman(a,b)}");

