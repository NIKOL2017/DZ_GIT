// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.

char[] elements = new char[]{'t', '8', '4'};

string GetStringFromArray()
{
    string str="";

    for (int i = 0; i < elements.Length; i++)
    {
        str = str+elements[i];
    }
    return str;
}

// string result = GetStringFromArray();
// System.Console.WriteLine(result);

System.Console.WriteLine(GetStringFromArray());


// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

System.Console.WriteLine("Введите строчку");
string userInput = Console.ReadLine();

char[] elements = new char[userInput.Length];

void GetArrayFromString()
{
    for (int i = 0; i < elements.Length; i++)
    {
        elements[i]= userInput[i];
    }
}

void PrintArray()
{
    foreach (char item in elements) // из массива достает и ложит значения в переменную
    {
        Console.Write(item + " ");
    }
    // for (int i = 0; i < elements.Length; i++)
    // {
    //     System.Console.Write(elements[i] + " ");
    // }
}

GetArrayFromString();
PrintArray();


// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

System.Console.WriteLine("Введите строчку");
string userInput = Console.ReadLine();

string vowels = "aeiyuo";

int GetCountVowels()
{
    int count =0;

    for (int i = 0; i < userInput.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if(userInput[i]==vowels[j])
            {
                count++;
                // count=count+1;
            }
        }
    }
    return count;
}
System.Console.WriteLine(GetCountVowels());

// Посмотреть функцию ToLower - сделать все буквы маленькими

// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

int[,] array = new int[4,2];

int sumInMax=0;
int indexMax=0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum=0;

   for (int j = 0; j < array.GetLength(1); j++)
   {
     array[i,j] = new Random().Next(0,10);
     System.Console.Write(array[i,j]+ " ");

     sum += array[i,j];
   }
    System.Console.WriteLine("сумма "+sum);

   if(sum>sumInMax)
   {
     sumInMax= sum;
     indexMax= i;
   }

   System.Console.WriteLine();
}

System.Console.WriteLine("\nИндекс макимальной = "+indexMax);


// Исправлено преподавателем
/ Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = new int [num];
// задаем первый массив

void Arr()
{
for(int i=0; i<arr.Length; i++)
{
arr[i] = new Random().Next(0, 21);
Console.Write(arr[i] +" ");
}
}

// формируем второй массив из первого
// int[] arr2 = new int [num]; (это пыталась второй массив создавать. Тогда без res. Но все равно выдает System.Int32[]. А почему не показывает перевернутый массив?)

int res=0;
for(int i=0; i<=arr.Length/2; i++)
{
res=arr[i];
arr[i] = arr[arr.Length-i-1];
arr[arr.Length-i-1]=res;

}

Arr();
Console.WriteLine();
// Console.WriteLine(arr); ошибка массив не выводят

Сама задача с кодом:
// Задача 3: Напишите программу, которая перевернёт одномерный массив
//  (первый элемент станет последним, второй – предпоследним и т.д.)

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = new int [num];
// задаем первый массив

void Arr()
{
for(int i=0; i<arr.Length; i++)
{
arr[i] = new Random().Next(0, 21);
Console.Write(arr[i] +" ");
}
}

Arr();
System.Console.WriteLine();

// формируем второй массив из первого
// int[] arr2 = new int [num]; (это пыталась второй массив создавать. Тогда без res. Но все равно выдает System.Int32[]. А почему не показывает перевернутый массив?)

int res=0;
for(int i=0; i< arr.Length/2; i++)
{
res=arr[i];
arr[i] = arr[arr.Length-i-1];
arr[arr.Length-i-1]=res;

}
Console.WriteLine(String.Join(" ", arr));// Вывод элементов массива через пробел

Console.WriteLine();