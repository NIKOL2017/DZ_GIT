// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
//  4 3 4 1 =>
//  2 9 5 4
// Обсудить этапы решения задачи
// Оформить этапы в виде функций
// 4 3 4 3
// 4 3 4 1
// 2 9 25 4

// int[,] array = new int[3,4];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindElementsArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i %2 ==0 && j%2==0)
//             {
//                 array[i,j]= array[i,j] * array[i,j];
//             }
//         }
//     }
// }

// CreateArray();
// PrintArray();
// FindElementsArray();
// PrintArray();



// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4

// int[,] array = new int[3,4];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindElementsArray()
// {
//     int sumElement=0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i ==j)
//             {
//                sumElement+= array[i,j];
//             //    sumElement= sumElement+ array[i,j];

//             }
//         }
//     }
//     System.Console.WriteLine("Сумма = " + sumElement);
// }

// CreateArray();
// PrintArray();
// FindElementsArray();





// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

// int[,] array = new int[3,4];
// double [] array2 = new double[array.GetLength(0)];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindElementsArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         double sumElement=0;

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
            
//                sumElement += array[i,j];
//             // sumElement= sumElement+ array[i,j];

            
//         }
//         array2[i] = sumElement/array.GetLength(1);
//     }
// }

// void PrintArray2()
// {
//     for (int i = 0; i < array2.Length; i++)
//     {
        
//             System.Console.Write(array2[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// CreateArray();
// PrintArray();
// FindElementsArray();
// PrintArray2();

//    8 / 3 = 2,3456789





// while (true) // Бесконечный цикл
//     {
//         Console.Write("Введите целое число (для выхода введите 'q'): ");  
//         string input = Console.ReadLine(); 
//         if (input == "q")  
//             {
//                 Console.WriteLine("STOP");  
//                 break;  
//             }
//         int number;  
//         if (int.TryParse(input, out number)) 
//         {
//             int sum = 0;  
//             for (int i = 0; i < input.Length; i++) 
//                 {
//                     sum += int.Parse(input[i].ToString());
//                 }

//             if (sum % 2 == 0) 
//             {
//                 Console.WriteLine("STOP");  
//                 break;  
//             }
//             else  // Если же нет то
//             {
//                 Console.WriteLine("Сумма цифр является нечетной."); 
//             }
//         }
//         else  
//         {
//             Console.WriteLine("Некорректный ввод. Введите целое число или 'q' для выхода."); 
//         }
//     }




    // Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
while(true)
{
    System.Console.WriteLine("Введите число");
    string userInput = Console.ReadLine();

    if(userInput== "q")
    {
        return;
    }

    int num = Convert.ToInt32(userInput);

int copeNum = num;
int sum=0;

while(copeNum>0)
{
    sum += copeNum%10;
    copeNum /=10;
}

if(sum%2==0)
{
    return;
}
}