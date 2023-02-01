/*

Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

вводим через один Enter (разбиваем через Split())

*/

Console.WriteLine("Enter the numbers separated by a space: ");

string numbers = Console.ReadLine();
string[] words = numbers.Split(' ');
int counter = 0;

for (int i = 0; i < words.Length; i++)
{
    if (Convert.ToInt32(words[i]) > 0)
        counter++;

}

Console.WriteLine($"The number of positive numbers is equal to {counter}.");
 