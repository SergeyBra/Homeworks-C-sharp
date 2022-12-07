//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

double[] array = FillArray(size, min, max);

Console.WriteLine($"Получившийся массив: [{string.Join(" ", array)}]");
Console.WriteLine(FindDifferenceMinMax(array));


double[] FillArray(int sizeArray, int minValue, int maxValue)
{
    Random random = new Random();
    double[] resultArray = new double[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue + 1);
    }
    return resultArray;
}

double FindDifferenceMinMax(double[] arr1)
{
    double MinN=arr1[0];
    double MaxN=arr1[0];

    for (int i = 1; i < arr1.Length; i++)
    {
        if (arr1[i] <= MinN)
        {
            MinN=arr1[i];
        }
        if (arr1[i] >= MaxN)
        {
            MaxN=arr1[i];
        }
    }
    double Dif= MaxN-MinN;
    return Dif;
}