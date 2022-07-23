// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] array = new int[4, 4];
GetArray(array);
PrintArray(array);

void GetArray(int[,] array)
{
    int number = 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[0, i] = number; number++;
    }
    for (int j = 1; j < array.GetLength(0); j++)
    {
        array[j, array.GetLength(1) - 1] = number; number++;
    }
    for (int k = array.GetLength(1) - 2; k >= 0; k--)
    {
        array[array.GetLength(0) - 1, k] = number; number++;
    }
    for (int l = array.GetLength(0) - 2; l > 0; l--)
    {
        array[l, 0] = number; number++;
    }
    for (int o = 1; o < array.GetLength(1)-1; o++)
    {
         array[1, o] = number; number++;
    }
    for (int p = 1; p < array.GetLength(0)-1; p++)
    {
        array[p, array.GetLength(1) - 2] = number; number++;
    }
    for (int q = array.GetLength(1) - 3; q >= 0; q--)
    {
        array[array.GetLength(0) - 2, q] = number; number++;
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
