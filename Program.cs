/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.*/

int[,] array1 = new int [4,4];
array1[0,0] = 1;

for (int j=1;j<array1.GetLength(1); j++)
        { 
            array1[0, j] = array1[0,0]+j;
            array1[j, array1.GetLength(1)-1] = array1.GetLength(1)+j;
        }
for (int j=0;j<array1.GetLength(1)-1; j++)
        { 
            array1[array1.GetLength(1)-1, j] = array1[array1.GetLength(1)-1,array1.GetLength(1)-1]+array1.GetLength(1)-1-j;
        }
for (int j=0;j<array1.GetLength(1)-1; j++)
    {
        array1[j+1, 0] = array1[array1.GetLength(1)-1,0]+2-j;
    }
for (int j=1;j<array1.GetLength(1)-1; j++)
        { 
            array1[array1.GetLength(1)-3, j] = array1[1,0]+j;
        }
for (int j=1;j<array1.GetLength(1)-2; j++)
array1[j+1, array1.GetLength(1)-2] = array1[1,2]+j;
array1[2,1] = array1[2,2]+1;

PrintArray(array1);
Console.WriteLine();

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