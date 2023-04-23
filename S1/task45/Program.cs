// Задача 45
// Напишите программу, которая будет создавать копию данного 
// массива с помощью поэлементного копирования 

Console.Clear();
int[] array = new int[]{1,2,3,4,5,6,7,8 ,0}; //1) создаем массив
PrintArray(array); //изначальный массив
int[] newArray = CorrectCopyIncrementArray(array);
PrintArray(newArray);//новый массив
PrintArray(array);//изначальный массив



int[] WrongCopyIncrementArray(int[] array)  //4) создаем ФУНКЦИЮ в которой каждый элемент будет увеличен на единицу 
{
     for (int i = 0; i < array.Length; i++)
    {
    array [i] = array[i] +1;  
    }
    return newArray; 
} 
 


int[] CorrectCopyIncrementArray(int[] array)  //2) создаем ФУНКЦИЮ в которой каждый элемент будет увеличен на единицу 
{
    int[] newArray = new int [array.Length]; //3) создаем копию массива той же длины  
    for (int i = 0; i < array.Length; i++)
    {
    newArray[i] = array[i] +1;  
    }
    return newArray; 
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


