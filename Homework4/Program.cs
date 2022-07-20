/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1) */

int[,,] Get3DArray(int firstIndex, int secondIndex, int thirdIndex, int deviation)
{
    int[,,] array3D = new int[firstIndex,secondIndex,thirdIndex];
    for (int i = 0; i < firstIndex; i++)
    {
        for (int j = 0; j < secondIndex; j++)
        {
            for (int k = 0; k < thirdIndex; k++)
            {
                array3D[i,j,k] = new Random().Next(-deviation, deviation + 1);
            }
        }
    }
    return array3D;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}
Console.WriteLine("Трехмерный массив с указанием индексов:");
int[,,] Array3D = Get3DArray(2,2,2,100);
Print3DArray(Array3D);