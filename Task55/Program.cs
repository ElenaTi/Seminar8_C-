/* Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя. */
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
void printArray(int[,] array)
{
        for (var i = 0; i < array.GetLength(0); i++)
    {
        
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] ChangeRowsToColumns(int[,] array)
{
    int[,] result = new int[array.GetLength(1),array.GetLength(0)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = array[j,i];
        }
    }
    return result;
}

int[,] ArrayFirst = generateArray(5,7,10);
printArray(ArrayFirst);
int[,] ArraySecond = ChangeRowsToColumns(ArrayFirst);
Console.WriteLine();
printArray(ArraySecond);