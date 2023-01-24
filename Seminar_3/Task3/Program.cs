
int [] CreateArray()
{
    int [] Array = new int [8];
    Random number = new Random();
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = number.Next(0,2);
    }
   return Array;
}
int [] a = CreateArray();

void PrintArray (int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
     Console.Write($" {array[i]} ");
   }
}
PrintArray(a);