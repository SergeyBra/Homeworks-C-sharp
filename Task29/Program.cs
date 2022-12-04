// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();

Console.WriteLine("Введите размерность массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] numbers=new int[num];

void FillandPrintArray (int[] array)
{
int length = array.Length;
int i=0;
while (i<length)
    {
       array[i]=new Random().Next(0,100);
       //Console.Write($"{array[i]}, ");
       i++;
    }
Console.WriteLine("["+String.Join(",", array) +"]");
}

FillandPrintArray(numbers);

