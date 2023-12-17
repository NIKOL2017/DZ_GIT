// Домашнее задание к 5-му семинару "Двумерные массивы"
//Задайте двумерный массив из целых чисел. Пользователь вводит 
// позиции элемента, выводится элемент либо сообщение , что его нет

 int[,] array = new int[3,4];

  void CreateArray() // Заполняем массив
   {
       for (int i = 0; i < array.GetLength(0); i++)
       {
           for (int j = 0; j < array.GetLength(1); j++)
           {
               array[i,j] = new Random().Next(1,10);
           }
       }
   }
CreateArray();
   void PrintArray() // Выводим массив
   {
       for (int i = 0; i < array.GetLength(0); i++)
       {
           for (int j = 0; j < array.GetLength(1); j++)
           {

               System.Console.Write(array[i,j] + " ");
           }
           System.Console.WriteLine();
       }
       System.Console.WriteLine();
   }
   PrintArray();
   
Console.WriteLine("Введите номер строки");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1<0|num1>array.GetLength(0)|num2<0|num2>array.GetLength(1))
{
    Console.WriteLine("Такого элемента нет ");
}
else
    for (int i = 0; i < array.GetLength(0); i++)
       {
         for (int j = 0; j < array.GetLength(1); j++)
         {
         if(i==num1&&j==num2)
         {
             Console.Write("Элемент найден "+ array[num1,num2] + " " );       
         } 
         } 
       }     

  