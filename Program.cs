/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


// Беру рандомные числа до 3, чтобы было легче проверить умножение

Console.Write($"Введите количество строк в первой матрице m1 = ");
int m1 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество столбцов в первой матрице n1 = ");
int n1 = int.Parse(Console.ReadLine()!);

Console.Write($"Введите количество строк в второй матрице m2 = ");
int m2 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество столбцов в второй матрице n2 = ");
int n2 = int.Parse(Console.ReadLine()!);

int[,] array1 = new int [m1,n1];
int[,] array2 = new int [m2,n2];
int[,] array3 = new int [m1,n2];

if (n1!=m2) Console.Write($"Умножение невозможно. Количество столбцов в первой матрице должно быть равно количеству строк во второй матрице");
else{
    for (int i=0; i<array1.GetLength(0); i++)           // Задаем первую матрицу
        {
            for (int j=0;j<array1.GetLength(1); j++)
            array1[i, j] = new Random().Next(0,3);
        }
PrintArray(array1);
Console.WriteLine();

for (int i=0; i<array2.GetLength(0); i++)           // Задаем вторую матрицу
    {
        for (int j=0;j<array2.GetLength(1); j++)
            array2[i, j] = new Random().Next(0,3);
    }
PrintArray(array2);
Console.WriteLine();

for (int i=0; i<array3.GetLength(0); i++)           // Переумножаем матрицы
    {
        for (int j=0;j<array3.GetLength(1); j++)
        {
            for (int k =0; k<array3.GetLength(1); k++)
            {
                array3[i, j] = array3[i, j]+array1[i,k]*array2[k,j];
            }
        }
    }
PrintArray(array3);
}

void PrintArray(int[,] matr)
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