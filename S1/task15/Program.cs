// Задача 15 смеминар 2 условие:
// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 1 || userNumber > 7) Console.WriteLine("Введите цифру, обозначающую день недели");

else if (userNumber == 6 || userNumber == 7) Console.WriteLine("Это выходной день");
else {Console.WriteLine("Это рабочий день");}
