/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[, ,] array1 = new int [2,2,3];

    for (int i=0; i<array1.GetLength(0); i++)           // 
        {
            for (int j=0;j<array1.GetLength(1); j++)
            { 
                for (int z=0;z<array1.GetLength(2); z++)
                array1[i, j, z] = new Random().Next(0,100);
            }
        }
PrintArray(array1);
Console.WriteLine();

void PrintArray(int[, ,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0;j<matr.GetLength(1); j++)
        {
            for (int z=0;z<matr.GetLength(2); z++)
            Console.Write($"{matr[i, j, z]},({i},{j},{z})");
        }
        Console.WriteLine();
    }
}