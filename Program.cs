/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49
*/

Console.WriteLine("Введите количество строк и столбцов первого двумерного массива через пробел!");
string[] arr1 = Console.ReadLine().Split(" ");
int row = int.Parse(arr1[0]);
int column = int.Parse(arr1[1]);
int[,] array1 = new int[row, column];
Console.WriteLine("Введите количество строк и столбцов второго двумерного массива через пробел и они должны совпадать с первым!!");
string[] arr2 = Console.ReadLine().Split(" ");
row = int.Parse(arr2[0]);
column = int.Parse(arr2[1]);
int[,] array2 = new int[row, column];
if (array1.GetLength(0) != array2.GetLength(0) && array1.GetLength(1) != array2.GetLength(1))
{
    Console.WriteLine("Количество строк и столбцов массивов не равны!");
    return;
}
Console.WriteLine("Вот первый сгенерированный двумерный массив");
CreateArray(array1);
PrintArray(array1);
Console.WriteLine("Вот второй сгенерированный двумерный массив");
CreateArray(array2);
PrintArray(array2);
Console.WriteLine("Вот сумма обеих массивов");
PrintArray(FindSumArray(array1, array2));


void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] FindSumArray(int[,] array1, int[,] array2)
{
    int[,] sumArray = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            sumArray[i, j] += array1[i, j];
        }
    }
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            sumArray[i, j] += array2[i, j];
        }
    }
    return sumArray;
}
