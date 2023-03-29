// Задача 4 условие: 
// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// Например:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

 Console.WriteLine("Вам нужно ввести три числа");
Console.WriteLine("Введите первое число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int userNumber3 = Convert.ToInt32(Console.ReadLine());
if (userNumber1 > userNumber2 && userNumber1 > userNumber3){Console.WriteLine("максимальное число " + userNumber1);}
else if (userNumber2 > userNumber1 && userNumber2 > userNumber3){Console.WriteLine("максимальное число " + userNumber2);}
else {Console.WriteLine("максимальное число " + userNumber3);}




 
 