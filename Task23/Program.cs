//Задача 23
//Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт таблицу кубов чисел от N до M.
//2,3 -> 8, 27


Console.Clear();

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
int i=N;
while (i<= M-1)
{
    double number=Math.Pow(i,3);
Console.Write($"{number}, ");
i++;
}
double number1=Math.Pow(M,3);
Console.Write(number1);