// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int[] array = new int [4];   //задаем массив и его значения 
array [0] = -4; 
array [1] = -8; 
array [2] = 8; 
array [3] = 2;
PrintArray(array); //выводим массив до изменений
ChangePosIntoNeg(array); 
PrintArray(array); //выводим массив после изменений

 void ChangePosIntoNeg(int[] array)               //замена положительных на отрицательные
  {
for (int i = 0; i < array.Length; i++)
    {
    array[i] *= -1;        
    }
  }

 void PrintArray(int[] array)                     //вывод массива 
{
    Console.Write("{");
    for (int i = 0; i < array.Length -1; i++)
    {
    Console.Write ($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");

}



 
// FillArray(array);
// PrintArray(array);
// //  Console.WriteLine($"Сумма положительных чисел = {PosSum(array)} ");
// //  Console.WriteLine($"Сумма отрицательных чисел = {NegSum(array)} ");


// void FillArray(int[] array)             //генерация массива 
// {
//    for (int i = 0; i < array.Length; i++)
//     {
//       array[i] = new Random().Next(-9, 10);
//     }

// }


 
//  void ChangePosIntoNeg(int[] array)               //замена положительных на отрицательные
//   {
// for (int i = 0; i < array.Length; i++)
//     {
//     array[i] *= -1;        
//     }
//   }




//  int NegSum(int[] array)               //сумма отрицательных
//   {
//     int sum = 0; 
// for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             sum += array[i];
//         }
        
//     }
//     return sum;
//   }



