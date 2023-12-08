//Задать массив из 10 целых чисел от 1 до 100.
//Найти количество элементов массива в отрезке от 20 до 90.
int[] array = new int[10];// задали массив из 10 элементов

for(int i =0; i<array.Length; i++) // заполняем
{
    array[i] = new Random().Next(1,101); // случайными числами 1-100
 System.Console.Write(array[i]+ " ");
}
int count=0; // переменную для подсчетf
for(var i =0; i<array.Length; i++) // от начального индекса
{ 
 if (array[i]>19 && array[i]<91) //проверяем диапазон 20-90
 count=count++;

}
    System.Console.WriteLine("Количество элементов "+count);



