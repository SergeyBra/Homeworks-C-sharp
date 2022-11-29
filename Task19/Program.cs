// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
if ((num <10000) || (num>99999))
{
    Console.WriteLine("Введено не пятизначное число");
}
else 
    {
    int fifth =(num%10);
    
    while (num>9999)
    {
      num = num/10;
    }
    int forth = num%10;

    while (num>99)
    {
      num = num/10;
    }
    int second = num%10;
    
    while (num>9)
    {
      num = num/10;
    }
    int first= (num%10);

   if ((first == fifth) && (second == forth))
    {
      Console.WriteLine("да, число палиндром");}
    else 
    {Console.WriteLine("нет, число не палиндром");}
    }