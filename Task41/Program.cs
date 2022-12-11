// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();

Console.WriteLine("Введите количество чисел, которые необходимо ввести вручную");
int size = Convert.ToInt32(Console.ReadLine());
int[] array= ManuallyFillArray(size);

Console.WriteLine($"Введены следующие числа: {string.Join(",", array)}");
Console.WriteLine($"Введено чисел больше 0: {CountPositiveNumbers(array)}");

int CountPositiveNumbers (int[] inputArray)
{
    int count=0;
    for (int i=0; i<inputArray.Length; i++)
    {
    if (inputArray[i]>0) count++;
    }
    return count;
}

int[] ManuallyFillArray(int sizeArray)
{
int[] result = new int[sizeArray];
   for (int i=0; i<sizeArray; i++)
{
   Console.WriteLine($"Введите число {i+1}");
   result[i] = Convert.ToInt32(Console.ReadLine());
}
return result;
}