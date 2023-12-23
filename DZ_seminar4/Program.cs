// Задача 3 Перевернуть одномерный массив

static void Mass()
{
int[] numbers = {2, 4, 3, 8, 5, 1}; 
int temp;
Console.Write("Элементы первого массива: ");
foreach (int number in numbers)
{
Console.Write(number + " ");
}
// Элементы  массива перевернутого
for (int i = 0; i < numbers.Length / 2; i++) // c cередины
{
// Меняем местами элементы
temp = numbers[i];
numbers[i] = numbers[numbers.Length - 1 - i];
numbers[numbers.Length - 1 - i] = temp;
}
// Вывод измененного массива
Console.Write("Перевернутый массив: ");
foreach (int number in numbers)
{
Console.Write(number + " ");
}
}
Mass();

// Задача 2: Задать массив, заполненный трехзначными случайными числами
// Посчитать  количество четных чисел в массиве

static void SumCH()
{
int[] numbersM = new int[10]; 
Random random = new Random(); 
int сount = 0; // Счетчик четных чисел
// Заполнение массива случайными трехзначными числами
for (int s = 0; s < numbersM.Length; s++)
{
numbersM[s] = random.Next(100, 1000); // Случайное число от 100 до 999
Console.Write(numbersM[s] + " "); 

if (numbersM[s] % 2 == 0) // проверяем на четность
{
count++ ;
}
}
// Вывод количества четных чисел в массиве
Console.WriteLine("Количество четных чисел в массиве  " + count);
}
SumCH();


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

// while(true)
// {
    // System.Console.WriteLine("Введите число");
    // string userInput = Console.ReadLine();

    // if(userInput== "q")
    // {
        // return;
    // }

    // int num = Convert.ToInt32(userInput);

// int copeNum = num;
// int sum=0;

// while(copeNum>0)
// {
    // sum += copeNum%10;
    // copeNum /=10;
// }

// if(sum%2==0)
// {
    // return;
// }
// }