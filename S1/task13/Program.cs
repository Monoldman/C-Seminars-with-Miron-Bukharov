// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int RandomUserNumber = Random.Shared.Next(0, int.MaxValue);
Console.WriteLine(RandomUserNumber);

if (RandomUserNumber < 100) Console.WriteLine(RandomUserNumber + " не хватает третьей цифры");

else
{
    while (RandomUserNumber > 999) 
    { 
        RandomUserNumber = RandomUserNumber / 10; 
    }
    Console.WriteLine(RandomUserNumber % 10);
}