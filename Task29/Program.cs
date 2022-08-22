// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void MasRandom(int[] array)
{
   
    for (int i = 0; i < 7; i++)
    {
        array[i] = new Random().Next(0, 8);
    }
    
}
void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length-1) Console.Write(array[i]+",");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}
Console.WriteLine("Вывод массива:");
int[] mas = new int[8];
MasRandom(mas);
ShowArray(mas);