// // Задача 2: 
// // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3


// // Console.WriteLine("Введите число"); 
// // int userNumber1 = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Введите второе число"); 
// // int userNumber2 = Convert.ToInt32(Console.ReadLine());
// // if (userNumber1 > userNumber2)Console.WriteLine("max = " + userNumber1 + " min = " + userNumber2);
// // else {Console.WriteLine("max = " + userNumber2 + " min = " + userNumber1);}




// // AТТЕСТАТ 


// /*
// // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// // в промежутке от N до 1. Выполнить с помощью рекурсии.

// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Clear();
// int Prompt(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int NaturalNumber(int n, int m)
// {
//   if (n == m) return n;
//   else Console.Write($"{NaturalNumber(n, m + 1)}, ");
//   return m;
// }

// int n = Prompt("Input N: ");
// if (n < 1)
// {
//   Console.WriteLine("Ввдите положительное число!");
//   return;
// }
// Console.WriteLine(NaturalNumber(n, 1));



// РЕШЕНИЕ 2:
 
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// NaturalToLow(number, count);


// void NaturalToLow(int n, int count)
// {
//     if (count > n)
//     {
//         return;
//     }
//     else
//     {
//         NaturalToLow(n, count + 1);
//         Console.Write(count + " ");
//     }
// }

// */




// /*

// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// // в промежутке от M до N.

// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// Console.Clear();
// int Prompt(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int SumOfElements(int m, int n)
// {
//   if (m == n) return m;
//   else return SumOfElements(m + 1, n) + m;
// }

// int m = Prompt("Input M: ");
// int n = Prompt("Input N: ");

// Console.WriteLine(SumOfElements(m, n));

// */

// // РЕШЕНИЕ 2:
 
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumFromMToN(m, n);

// // вызов функции "сумма чисел от M до N"
// void SumFromMToN(int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }

// // функция сумма чисел от M до N
// int SumMN(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }



// /*
// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// // Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29

// Console.Clear();
// int Prompt(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int Akkerman(int m, int n)
// {
//   if (m == 0) return n + 1;
//   if (m > 0 && n == 0) return Akkerman(m - 1, 1);
//   else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// int m = Prompt("Input M: ");
// int n = Prompt("Input N: ");

// Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");

// */

 
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m,n);


// // вызов функции Аккермана
// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }

// // функция Аккермана
// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }









