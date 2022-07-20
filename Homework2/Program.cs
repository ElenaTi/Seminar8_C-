/*  Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка  */

int [,] GetArray (int rows, int columns, int deviation)
{
    int[,] resultArray = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = new Random().Next(-deviation,deviation + 1);
        }
    }
    return resultArray;
}
void PrintArray(int[,] array)
{
    Console.Write("N\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"{i}\t");
        
    }
    Console.WriteLine();
    Console.WriteLine("-----------------------------------------------------------");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{i} |\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {            
            Console.Write(array[i,j]);
            if (j < array.GetLength(1) - 1)
            {
                Console.Write("\t");
            }
        }
         Console.WriteLine();       
    } 
}

int[] SumOfRows(int[,] array)
{
    int[] arrayOfSums = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        arrayOfSums[i] = sum;
        sum = 0;
    }
    return arrayOfSums;
}

int FindMinSumRow (int[] array)
{
    int min = array[0];
    int numberMinRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            array[i] = min;
            numberMinRow = i;
        }
    }
    return numberMinRow;
}

int[,] arrayForTask = GetArray(6,7,100);
Console.WriteLine("Массив для нахождения строки с наименьшей суммой:");
PrintArray(arrayForTask);
Console.WriteLine();
int[] sums = SumOfRows(arrayForTask);

int minSummRow = FindMinSumRow(sums);
Console.WriteLine($"Строка с наименьшей суммой элементов под номером: {minSummRow}");

