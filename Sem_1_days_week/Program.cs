// Дни недели по запросу цифрой
Console.WriteLine("Введите номер дня недели");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if (number == 1)

{
    Console.WriteLine("Он называется : Понедельник");
}

else if (number == 2)

{
    Console.WriteLine("Он называется : Вторник");
}
else if (number == 3)

{
    Console.WriteLine("Он называется : Среда");
}
else if (number == 4)

{
    Console.WriteLine("Он называется : Четверг");
}

else if (number == 5)

{
    Console.WriteLine("Он называется : Пятница");
}
else if (number == 6)

{
    Console.WriteLine("Он называется : Суббота");
}
else if (number == 7)

{
    Console.WriteLine("Он называется : Воскресенье");
}

else

{
    Console.WriteLine("Такого дня нет");
}
