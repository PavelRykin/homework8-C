/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("Введите количество строк и столбцов через пробел");
string[] arr = Console.ReadLine().Split(" ");
int row = int.Parse(arr[0]);
int column = int.Parse(arr[1]);
int[,] array = new int[row, column];
Console.WriteLine("Вот сгенерированный двумерный массив");
CreateArray(array);
PrintArray(array);
int MinSumNumbers = 0;
int sumRow = SumRowNumbers(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumRow = SumRowNumbers(array, i);
    if (sumRow > tempSumRow)
    {
        sumRow = tempSumRow;
        MinSumNumbers = i;
    }
}

Console.WriteLine($"\n{MinSumNumbers + 1} - строкa с наименьшей суммой ({sumRow}) элементов ");

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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SumRowNumbers(int[,] array, int i)
{
    int sumRow = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
    }
    return sumRow;
}