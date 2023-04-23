// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



Console.WriteLine("Введите общее количество чисел: ");
int amountOfNumbers = int.Parse(Console.ReadLine()!);
int result = CheckNumbersGreaterThanZero(amountOfNumbers);
Console.WriteLine($"Количество чисел больше 0: {result}");

int CheckNumbersGreaterThanZero(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Введите число {i}: ");
        int number = int.Parse(Console.ReadLine()!);
        if (number > 0) 
        count++;
    }
    return count;
}



