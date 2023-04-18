// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 



        Console.Clear();
        int[] array = new int[5]; // задаем размер массива
        FillArray(array, 1, 5); // задаем массив через функцию гененрации массива 
        PrintArray(array);
        PrintArray(MultiplyPairs(array));

        void FillArray(int[] array, int min, int max)             //ФУНКЦИЯ генерации рандомного  массива 
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max + 1);  // +1  тк  Random().Next не включает последнее значение
            }

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
        int[] MultiplyPairs(int[] array)
        {
            int firstPointer = 0;
            int secondPointer = array.Length - 1;
            int pairPointer = 0;
            int[] pairsMultiply = new int[(array.Length +1) / 2];
            while (firstPointer < secondPointer)
            {
                pairsMultiply [pairPointer] = array[firstPointer] * array[secondPointer];
                firstPointer++;
                secondPointer--;
                pairPointer++;
            }
            if (firstPointer == secondPointer)
            {
                pairsMultiply [pairPointer] = array[firstPointer]; // *1;
            }
             return pairsMultiply;
        }


 
