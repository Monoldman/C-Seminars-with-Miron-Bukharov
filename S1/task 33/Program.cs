// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да




int[] array = {6, 7, 19, 345, 3};
PrintArray(array);
Console.WriteLine("Введите число, которое надо найти");
int number = ReadNumberFromConsole();
bool result = FindNumberInArray(array, number); // использование функции
if (result == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
 
bool FindNumberInArray(int[] array, int numberToSearch) // ФУНКИЦЯ посиск числа 
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numberToSearch)
        {
            return true;
        }
    }
    return false;
}
 
void PrintArray(int[] array) // ФУНКИЦЯ вывод массива 
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");
}
 
int ReadNumberFromConsole() // ФУНКИЦЯ вывод числа 
{
    string input = Console.ReadLine();
    return int.Parse(input);
}


