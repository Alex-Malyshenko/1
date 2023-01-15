/* Принимаем целое число. ввыодим целые числа от -число до + число 
*/
// Дни недели по запросу цифрой
Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

 for (int i = -number; i <= number; i++)
 {
    Console.Write(i + " ");
 }