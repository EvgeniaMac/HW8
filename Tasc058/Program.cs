// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


Console.WriteLine("Введите количество строк массивов: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцы массивов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
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
int[,] Array = GetArray(rows, columns, 0, 10);
int[,] SecondArray = GetArray(rows, columns, 0, 10);

int[,] GetMatrix(int k, int l)
{
    int[,] matrix = new int[k,l];
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < l; j++)
        {
            matrix[i, j] = Array [i,j]*SecondArray[i,j];
        }
    }
    return matrix;
}

int[,] FinalArray = GetMatrix(rows, columns);

Console.WriteLine();
PrintArray(Array);
Console.WriteLine("И:");
PrintArray(SecondArray);
Console.WriteLine("Перемножим элементы этих массивов:");
PrintArray(FinalArray);