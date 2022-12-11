// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите переменную b1");
Double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1");
Double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2");
Double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2");
Double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Точка пересечения двух прямых: {FindDoubleersectionPoDouble(b1,k1,b2,k2)}");

(double,double) FindDoubleersectionPoDouble (Double b01, Double k01, Double b02, Double k02)
{
     double x=(b02-b01)/(k01-k02);
     double y=k02*x+b02;
     return (x,y);
}