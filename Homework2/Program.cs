// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] FillArray(int columns, int rows, int minValue, int maxValue)
{
    int[,] arr = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            arr[i, l] = rand.Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix[i, l] + " ");
        }
        Console.WriteLine();
    }
}

void SwapRows(int[,] matrix)
{
    int columnsCount = matrix.GetLength(1);
    int rowCount = matrix.GetLength(0)-1;
    int row1 = 0;

    int temp;

    for (int i = 0; i < columnsCount; i++)
    {
        temp = matrix[row1, i];
        matrix[row1, i] = matrix[rowCount, i];
        matrix[rowCount, i] = temp;
    }
}

int rows = new Random().Next(3, 10 + 1);
int columns = new Random().Next(3, 10 + 1);

int[,] array = FillArray(columns, rows, 1, 10);

PrintArray(array);

Console.WriteLine(" ");

SwapRows(array);

PrintArray(array);