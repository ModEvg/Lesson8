/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/
Console.Write($"Введите количество строк m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество столбцов n = ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int [m,n];

for (int i=0; i<array.GetLength(0); i++)           // Задаем массив
    {
        for (int j=0;j<array.GetLength(1); j++)
            array[i, j] = new Random().Next(0,10);
    }
PrintArray(array);
int a = 0;
for (int i=0; i<array.GetLength(0); i++)
    {
        while (a<array.GetLength(1))
        {
            bool swapped = false;
            for (int j=0;j<array.GetLength(1)-1; j++)
            {
                if (array[i,j]<array[i,j+1])
                {
                    (array[i,j],array[i,j+1]) = (array[i,j+1],array[i,j]);
                    swapped = true;
                }
            }
            if (swapped == false)
            break;
        }
    }

Console.WriteLine();
PrintArray(array);

void PrintArray(int[,] matr)   //Вывод массива
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