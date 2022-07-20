/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
10 6 24 49  */

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
    Console.WriteLine("------------------------------------------------");
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

int[,] CompositionOfTwoMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] compositionOfMatrix = new int[firstArray.GetLength(0),secondArray.GetLength(1)];
    if (firstArray.GetLength(1) == secondArray.GetLength(0))
    {
        
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            int buffElement = 0;
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                
                for (int s = 0; s < firstArray.GetLength(1); s++)
                {
                    buffElement = buffElement + firstArray[i,s] * secondArray[s,j];
                    
                }                 
                compositionOfMatrix[i,j] = buffElement;
                buffElement = 0;                
            }                        
        }        
    }
    else
    {
        Console.WriteLine("нельзя умножить эти две матрицы.");
    }
    return compositionOfMatrix;
}
int[,] firstMatrix = GetArray(2,3,10);
int[,] secondMatrix = GetArray(3,2,10);
Console.WriteLine("Первая матрица:");
PrintArray(firstMatrix);
Console.WriteLine("Вторая матрица:");
PrintArray(secondMatrix);
Console.WriteLine("Матрица произведения: ");
int[,] composition = CompositionOfTwoMatrix(firstMatrix,secondMatrix);
PrintArray(composition);