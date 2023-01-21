/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

int[] array = new int[5];

Console.Write("Input five-digit number:");

int number = Convert.ToInt32(Console.ReadLine());
for (int i = 4; i >= 0; i--) 
{
    array[i] = number % 10;
    number /= 10;
}

if (array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine($"This number is a polydrome!");
}
else
{
    Console.WriteLine("Attention! This number is not a polydrome !");
}


