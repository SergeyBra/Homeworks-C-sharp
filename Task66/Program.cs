// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.WriteLine("Задайте число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindSumOfElements(M,N));
int FindSumOfElements(int M1, int N1)
{
    if (M1>N1) return 0;
    int sum=M1;
    sum +=FindSumOfElements(M1+1, N1);
    return sum;
    // Console.Write($"{M1} ");
    // ShowNumber(M1+1, N1);
} 
FindSumOfElements(M,N);