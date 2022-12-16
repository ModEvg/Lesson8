/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.Write($"Введите количество строк m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество столбцов n = ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int [m,n];
int [] summa = new int[array.GetLength(0)];

for (int i=0; i<array.GetLength(0); i++)           // Задаем массив
    {
        for (int j=0;j<array.GetLength(1); j++)
            array[i, j] = new Random().Next(0,10);
    }
PrintArray(array);


for (int i=0; i<array.GetLength(0); i++)  // Нахождение суммы элементов в каждой строке
    {
        for (int j=0;j<array.GetLength(1); j++)
        {
            summa[i] = summa[i] + array[i,j];
        }
            
    }
for (int j1=0;j1<array.GetLength(0); j1++)
Console.WriteLine($"Сумма элементов в {j1} строке равна {summa[j1]}");

int min = summa[0];
int k = 0;

for (int j1=1;j1<array.GetLength(0); j1++)  // Нахождение минимального значения среди всех сумм
    if (summa[j1]<min) {min = summa[j1]; k = j1;}

Console.WriteLine($"Наименьшая сумма равна {min} во {k} строке");


void PrintArray(int[,] matr)  // Вывод массива на экран
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0;j<matr.GetLength(1); j++)
        {
            Console.Write("{0,3}", matr[i, j]);
        }
        Console.WriteLine();
    }
}