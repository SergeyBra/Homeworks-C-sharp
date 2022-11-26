// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Clear();

Console.WriteLine("Введите число, обзначающее день недели");
int num = int.Parse(Console.ReadLine());
if ((num <1) || (num>7))
{
    Console.WriteLine("Это число не обозначает день недели");
}
else if (num ==6 || num == 7)
{
    Console.WriteLine("Да, выходной");
}
else
{
  Console.WriteLine("Нет,не выходной");  
}
