/* Принимаем целое трехзначное число. 
выводим последнюю  его цифруло 
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

Console.WriteLine(number % 10);