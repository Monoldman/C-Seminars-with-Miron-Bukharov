// Задача N29: Напришите программу, которая перевернет одномерный массив (последний элемент 
//бдует на первом месте, а первый - на последнем и тд.).
//[123455] -> [54321]
//[6736] -> [6376]


int[] array = new int[] {1,2,3,4,5,6,7,8,9,0 };

PrintArray(array);
ReverseArray(array);
PrintArray(array);


void ReverseArray (int[] array)  //ФУНКЦИЯ принимает и преобразовывает массив

{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int buf = array [array.Length -i -1];
        array [array.Length -i -1] = array [i];
        array[i] = buf;
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

