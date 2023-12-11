//Первое задание. Задать массив из 10 целых чисел от 1 до 100.
//Найти количество элементов массива в отрезке от 20 до 90.
int[] array = new int[10];// задали массив из 10 элементов

for(int i =0; i<array.Length; i++) // заполняем
{
    array[i] = new Random().Next(1,101); // случайными числами 1-100
 System.Console.Write(array[i]+ " "); // вывели на экран 
}
int count=0; // переменная для подсчета
for(var i=0; i<array.Length; i++) // начали от начального индекса
{ 
 if (array[i]>19 && array[i]<91) //проверяем диапазон 20-90
 count=count+1;
}
    System.Console.WriteLine("Количество элементов в диапазоне от 20 до 90  "+count);

    // Второе задание.Задать массив из  10 целых чисел.
//Напишите программу, которая определяет количество ЧЕТНЫХ чисел

int[] array1 = new int[10];// задали массив из 10 элементов

for(int n=0; n<array1.Length; n++) // заполняем
{
    array1[n] = new Random().Next(); // случайными числами 
 System.Console.Write(array1[n]+ " ");
}
int count1=0; // переменная для подсчета
for(var n=0; n<array1.Length; n++) // от начального индекса
{ 
 if (array1[n]%2==0 ) //проверяем на четность
 count1=count1+1;
}
Console.WriteLine("Количество четных элементов "+count1);

// Третье задание.Задать массив из  вещественных чисел с ненулевой дробной частью.
//Найдите разницу между максимальным и минимальным значениями массива.

double[] array3 = new double[5];// сделать вещественными и неопределенным ?? кол.эл-в

for(int m=0; m <array3.Length; m++) // заполняем
{
    array3[m] = new Random().NextDouble(); // случайными числами вещественными 
Console.Write(array3[m]+ " "); // вывод 
}
double maximum=array3[0];
double minimum=array3[0];
for(int m=0; m<array3.Length; m ++) // движение от элемента с нулевым индексом
{ 
 if (array3[m] > maximum ) //ищем максимум
 {
 array3[m]=maximum;
} 
//  m++;
 if (array3[m]<minimum ) //ищем минимум
 {
 array3[m]=minimum;
}
// m++;
}

Console.WriteLine("Максимум  "+ maximum);
Console.WriteLine("Минимум  "+ minimum);
double raz = maximum - minimum;
Console.WriteLine("Разница между Максимум и Минимумом  "+ raz);

