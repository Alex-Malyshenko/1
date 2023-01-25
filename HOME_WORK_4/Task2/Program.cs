/* 
Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

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

int number = GetNumber("Введите число: ");
int sum = 0;
string number_str = Convert.ToString(number);

for (int i = 0; i < number_str.Length; i++)
{
    char temp = number_str[i];
    sum = sum + Convert.ToInt16(number_str[i]-'0');
}
Console.WriteLine($"Сумма цифр числа: {sum}");