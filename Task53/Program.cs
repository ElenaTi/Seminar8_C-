/* Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива. */
int[,] generateArray(int rowLength, int colLength, int deviation)
{
    int[,] result = new int[rowLength, colLength];
    for (var i = 0; i < rowLength; i++)
    {
        for (var j = 0; j < colLength; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return result;
}
void printColor(string message, ConsoleColor color = ConsoleColor.Green)
{
    Console.ForegroundColor = color;
    Console.Write($"{message}\t");
    Console.ResetColor();
}
void showHead(int numbers, string nameOfArray)
{
    if (!string.IsNullOrEmpty(nameOfArray))
    {
       printColor($"-------------------------- {nameOfArray} --------------------------", ConsoleColor.DarkCyan);
       Console.WriteLine();
    }
    Console.Write(" \t");
    for (var i = 0; i < numbers; i++)
    {
        printColor($"{i}");
    }
     Console.WriteLine();
}
void printArray(int[,] array, string nameOfArray = "")
{
    showHead(array.GetLength(1),nameOfArray);
    for (var i = 0; i < array.GetLength(0); i++)
    {
        printColor($"{i}");
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] deepCloneArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0),array.GetLength(1)];     
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            result[i,j] = array[i,j];
        }
    }
    return result;
}
int[,] swopRowsOfArray(int[,] array,int rowOne, int rowTwo)
{
    int[,] result = deepCloneArray(array);
    if (rowOne < result.GetLength(0) && rowTwo < result.GetLength(0))
    {
        for (var i = 0; i < result.GetLength(1); i++)
        {
            int buffer = result[rowOne,i];
            result[rowOne,i] = result[rowTwo,i];
            result[rowTwo,i] = buffer;
        }
    }
    else
    {
        printColor($"ОШИБКА: Размер строк для смены должен быть меньше {array.GetLength(0)-1}",ConsoleColor.DarkRed);
        Console.WriteLine();
        printColor($"Вы ввели {rowOne} {rowTwo}",ConsoleColor.DarkRed);
        Console.WriteLine();
    }
    return result;
}

int[,] array = generateArray(5,7,10);
printArray(array, "Изначальный");
int[,] swappedArray  = swopRowsOfArray(array,0,array.GetLength(0));
printArray(swappedArray, "поменяли первую и последнюю строку массива");
