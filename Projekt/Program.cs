
// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении использовать массивы.
string[] arrayOrig = new string[5] {"123", "235", "hello", "world", "res"};// Исходный массив
string[] arrayResult = new string[arrayOrig.Length];  // Результирующий массив
void ResultArr(string[] arrayOrig, string[] arrayResult)
{
    int count = 0;
    for (int i = 0; i < arrayOrig.Length; i++)
    {
    if(arrayOrig[i].Length <= 3)
        {
        arrayResult[count] = arrayOrig[i];
        count++;
        }
    }
}
void PrintArr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ResultArr(arrayOrig, arrayResult);
PrintArr(arrayResult);
