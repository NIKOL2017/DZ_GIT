//  Задайте значение М и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от М до N.
// Использовать рекурсию. Не использовать цикл.

//  Console.WriteLine("Введите число m ");
//  int m = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите число n: ");
//  int n = Convert.ToInt32(Console.ReadLine());

//  static void ConsolNum(int start, int end) // Метод вывода на консоль
//     {
//         if (start >= end)
//         {
//          Console.WriteLine("Выход из рекурсии");
//           return; // Выход если первое число больше или равно второго
//         }
// Console.WriteLine(start);
//         ConsolNum(start + 1, end);   // Рекурсия      
//     }    
//         ConsolNum(m, n); // Передаем значения m и n вызываемому методу


//Задача 3: Задайте произвольный массив. 
// Выведите его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

//  int[] Array = {1, 2, 5, 0, 10, 34 }; // Задали произвольный массив 

//   static void ConsolArrFromEnd(int[] arr, int index) //Метод вывода элементов с конца
//     {
//         if (index >= 0)
//         {
//             Console.WriteLine(arr[index]);
//             ConsolArrFromEnd(arr, index - 1); //по-шагово от конца массива
//         }
//     }
// ConsolArrFromEnd(Array, Array.Length - 1);// Передаем методу параметры массива,
//                                          //где index = длинна массива -1 (движение от конца)


//Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

 Console.WriteLine("Введите число m ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число n: ");
 int n = Convert.ToInt32(Console.ReadLine());

 int fa = FunctionAkkermann(n, m);
 Console.WriteLine($"Значение функции Аккермана для ({n}, {m})  {fa}");


 static int FunctionAkkermann(int n, int m)
    {
        if (n == 0)
            return m + 1;
        else if (n > 0 && m == 0)
            return FunctionAkkermann(n - 1, 1);
        else if (n > 0 && m > 0)
            return FunctionAkkermann(n - 1, FunctionAkkermann(n, m - 1));
        else throw new Exception("Значения n и m некорректны");   // исключение       
    }
