// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8
Console.Clear();
Console.WriteLine("Задайте число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число N");
int N = Convert.ToInt32(Console.ReadLine());

void FindNumbersBetweenMN(int M1, int N1)
{
    if (M1>N1) return;
    if (M1%2==0){
    Console.Write($"{M1} ");
    }
    FindNumbersBetweenMN(M1+1, N1);
} 
FindNumbersBetweenMN(M,N);