// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] FillArray (int columns, int rows, int minValue, int maxValue)
{
    int[,] arr = new int [rows, columns];
    Random rand = new Random(); 
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            arr[i,l] = rand.Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] matrix)
{
    for (int i =0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
           Console.Write(matrix[i,l] + " ");
        }
        Console.WriteLine();
    }
}

void GetMinSummRows(int[,] arr)
{
    int min = 0;
    int summ= 0;
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ += arr[i,j];
        }
        if (summ < min || min == 0)
        {
            min = summ;
            count++;
        }
        summ = 0;
    }
    Console.WriteLine($"строка {count} с наименьшей суммой элементов ");
}

int[,] array = FillArray(4, 3, 1, 10);

PrintArray(array);

Console.WriteLine(" ");

GetMinSummRows(array);

