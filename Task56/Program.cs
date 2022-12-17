// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей
//суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, min, max);

PrintArray(array);
Console.WriteLine();

//Console.WriteLine($"Получившийся одномерный массив: [{string.Join(",", CreateArrayFromSumsOfRows(array))}]");
Console.WriteLine($"номер строки с наименьшей суммой элементов: {FindMinElement(CreateArrayFromSumsOfRows(array))} строка");

int[] CreateArrayFromSumsOfRows(int[,] arr)
{
    int[] newarray = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newarray[i] += arr[i, j];
        }
    }
    return newarray;
}

int FindMinElement(int[] arr1)
{
    int min = arr1[0];
    int minIndex = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] < min)
        {
            min = arr1[i];
            minIndex = i;
        }
    }
    return minIndex+1;
}

int[,] FillArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
