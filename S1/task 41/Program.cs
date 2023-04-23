// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountNumbers()
{
    int count = 0;
    string word;
    while (true)
    {
        Console.Write("Output any number: ");
        word = Console.ReadLine()!;

        if (word == "") return count;
        else if (int.Parse(word) > 0) count += 1;
    }
}

int count = CountNumbers();
Console.WriteLine($"Numbers greater than zero: {count}"); 


// 2й вариант решения

int Check(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int a = int.Parse(Console.ReadLine()!);
        if (a > 0) count++;
    }
    return count;
}

Console.WriteLine("Сколько чисел хотели бы вывести?: ");
int a = int.Parse(Console.ReadLine()!);
int result = Check (a);
Console.WriteLine($"Количесво чисел больше 0: {result}");

