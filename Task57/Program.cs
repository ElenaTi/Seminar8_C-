/* Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз 
встречается элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */

int[,] generateArray(int rowLength, int colLength)
{
    int[,] result = new int[rowLength, colLength];
    for (var i = 0; i < rowLength; i++)
    {
        for (var j = 0; j < colLength; j++)
        {
            result[i, j] = new Random().Next(0, 10);
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

void GetCountOfNumbers(int[,] array)
{
    int count =0;
    for (int k = 0; k < 10; k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] == k)
                {
                    count = count +1;
                }
            }
        }
        if (count > 0)
        {
            Console.WriteLine($"Число {k} встречается {count} раз.");         
            count = 0;
        }
    }
}

int[,] ArrayForTask = generateArray(5,7);
printArray(ArrayForTask);
GetCountOfNumbers(ArrayForTask);