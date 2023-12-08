// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да
// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[5];

// bool isFind =false;

// for(int i =0; i<array.Length; i++)
// {
    // array[i] = new Random().Next(0,4);   // -191   205
    // System.Console.Write(array[i]+ " "); вывод с пробелом

    // if(array[i] == num)
    // {
        // isFind=true;
    // }
// }


// if(isFind == true)
// {
    // Console.WriteLine("Да");
// }
// else
// {
    // Console.WriteLine("Нет");
// }

//Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]
 
int[] array = new int[10];// задали массив из 10 элементов

for(int i =0; i<array.Length; i++) // заполняем
{
    array[i] = new Random().Next(1,101); // случайными числами 1-100
 System.Console.Write(array[i]+ " ");
}
int count=0; // переменную для подсчета
// Console.WriteLine();
for(int i =0; i<array.Length; i++) // от начального индекса
{ 
 if (i>19 && i<91) //проверяем диапазон 20-90
 count++;
    // array[i] = array[i] *-1; 
    Console.WriteLine();
    System.Console.WriteLine(count);
}




