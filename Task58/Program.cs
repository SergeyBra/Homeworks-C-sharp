// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива 1");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива 1");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве 1");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве 1");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк двумерного массива 2");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива 2");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве 2");
int min1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве 2");
int max1 = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, min, max);
int[,] array1 = FillArray(rows1, columns1, min1, max1);

PrintArray(array);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
PrintArray(MultiplyArrays(array, array1));


int[,] MultiplyArrays(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0))
    {
       throw new Exception("Матрицы нельзя перемоножить");
    }
    int[,] resultarray = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(0); k++)
            {
                resultarray[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return resultarray;
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
