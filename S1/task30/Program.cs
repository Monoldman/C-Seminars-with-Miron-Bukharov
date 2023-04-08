// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

















/* 
void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(0, 2);
    }
 
}
 
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count - 1)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.Write($"{col[position]}");
}
 
Console.Clear();
 
int[] array = new int[100];
FillArray(array);
PrintArray(array);
*/