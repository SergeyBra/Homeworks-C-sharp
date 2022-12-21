// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7
Console.Clear();
Console.WriteLine("Задайте число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindLagestDivisor(M,N));
Console.WriteLine();
Console.WriteLine(6%12);
int FindLagestDivisor(int M1, int N1)
{
    if (N1==0) return M1;
    else return FindLagestDivisor(N1,M1%N1);
}

// int num = 0;
// if (M > N)
// {
//     for (int i = 1; i <=N; i++) 
//     { 
//         if (M%i==0 && N%i==0)
//         {
//             num = i;
//         }
//     }
//   Console.WriteLine(num);
// }
// else 
// {
//   for (int i = 1; i <=M; i++) 
//     { 
//         if (M%i==0 && N%i==0)
//         {
//             num = i;
//         }
//     }
//   Console.WriteLine(num);  
// }


