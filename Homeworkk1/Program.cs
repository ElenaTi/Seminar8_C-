/* Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8  */

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
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"{i}\t");
        
    }
    Console.WriteLine();
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{i}\t");
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
int[,] CopyArray(int[,] array)
{
    int[,] copyArray = new int[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            copyArray[i,j] = array[i,j];
        }   
    } 
    return copyArray;
}
int[,] OrganizeRowsOfArray (int[,] array, int numberOfRow)
{
    int[,] organizedArray = CopyArray(array);   
    if (numberOfRow >=0 && numberOfRow < organizedArray.GetLength(0))
    { 
        for (int i = 0; i < organizedArray.GetLength(1); i++)
        {
              for (int j = 0; j < organizedArray.GetLength(1) - 1; j++)
              {
                    if (organizedArray[numberOfRow,j] > organizedArray[numberOfRow,j + 1])
                    {
                        int buff = organizedArray[numberOfRow,j];
                        organizedArray[numberOfRow,j] = organizedArray[numberOfRow,j+1];
                        organizedArray[numberOfRow,j + 1] = buff;
                    }
                }
         }
    }
    else
    {
        Console.WriteLine($"Строка, которую нужно отсортировать, должна быть меньше {organizedArray.GetLength(0)}");
    }
    return organizedArray;
}

int[,] arrayForOrganize = GetArray(5,3,100);
PrintArray(arrayForOrganize);
Console.WriteLine("Массив с упорядоченной строкой");
int[,] regulirizedRowsOfArray = OrganizeRowsOfArray(arrayForOrganize,0);
PrintArray(regulirizedRowsOfArray);
