// Ввести координаты точки на плоскости (х,у)
//Выдать номер коодинатной четверти, где находится точка.
// using System.Security.Cryptography.X509Certificates;

// Console.WriteLine("Введите координаты Х");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты Y");
// int Y = Convert.ToInt32(Console.ReadLine());
// if(X>0&&Y>0)        //  && - и    || - или
// {
// Console.WriteLine("1 четверть");
// }
// if(X<0&&Y>0)        //  && - и    || - или
// {
// Console.WriteLine("2 четверть");
// }
// if(X<0&&Y<0)        //  && - и    || - или
// {
// Console.WriteLine("3 четверть");
// }
// if(X>0&&Y<0)        //  && - и    || - или
// {
// Console.WriteLine("4 четверть");
// }

// Задача 3 принимает на вход целое число из отрезка [10,99].
// Показывает наибольшую цифру этого числа.
// Console.WriteLine("Введите число");
using System.Runtime.ExceptionServices;

int num = new Random().Next(10,99);
Console.WriteLine(num);
if (num >= 10 &&num<=99)
{
int first=num/10; // нашли цифру десятки
int second=num%10;//остаток от деления на 10 - вторая цифра числа
int max=first;
if (first>max)
{
Console.WriteLine("Максимальное число  "+ first);
}
else
{
Console.WriteLine("Максимальное число  "+ second);
}
}
