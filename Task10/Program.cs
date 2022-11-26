//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
Console.Clear();
Console.WriteLine ("Введите трехзначное число");
int num = int.Parse (Console.ReadLine());
if ((num<100) || (num>999))
{
Console.WriteLine ("Введено не трехзначное число");   
}
else 
{
int num1 = num / 10;
int num2 = num1 % 10;
Console.WriteLine ($"Вторая цифра этого числа: {num2}");
}
