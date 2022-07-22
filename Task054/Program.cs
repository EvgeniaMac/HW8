// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] array = { { 6,1,7,3 }, { 8,5,9,4 }, { 5,0,3,7 } };
Console.WriteLine("Задан массив:");
PrintArray(array);
Console.WriteLine("Отсортируем строчки по убыванию:");
SortArray(array);
PrintArray(array);

void SortArray(int[,] matrix)
{
    matrix = array;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k + 1];
                        array[i, k + 1] = array[i, k];
                        array[i, k] = temp;
                    }
                }

            }
        }
    }
}
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}