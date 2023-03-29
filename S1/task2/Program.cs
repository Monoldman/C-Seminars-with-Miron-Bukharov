// Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите число"); 
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число"); 
int userNumber2 = Convert.ToInt32(Console.ReadLine());
if (userNumber1 > userNumber2)Console.WriteLine("max = " + userNumber1 + " min = " + userNumber2);
else {Console.WriteLine("max = " + userNumber2 + " min = " + userNumber1);}



