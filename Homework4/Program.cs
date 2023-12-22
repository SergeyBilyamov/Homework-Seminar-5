// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца

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

int[,] FindPositionSmallElement(int[,] array, int[,] position)
{
    int temp = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] <= temp)
            {
                position[0, 0] = i;
                position[0, 1] = j;
                temp = array[i, j];
            }
        }
    }
    return position;
}

void TrimArray(int rowToRemove, int columnToRemove, int[,] originalArray)
{
    int[,] result = new int[originalArray.GetLength(0) - 1, originalArray.GetLength(1) - 1];
    for (int i = 0, j = 0; i < originalArray.GetLength(0); i++)
    {
        if (i == rowToRemove)
            continue;
        for (int k = 0, u = 0; k < originalArray.GetLength(1); k++)
        {
            if (k == columnToRemove)
                continue;
            result[j, u] = originalArray[i, k];
            u++;
        }
        j++;
    }
    PrintArray(result);
}

int rows = new Random().Next(3, 10 + 1);
int columns = new Random().Next(3, 10 + 1);

int[,] array = FillArray(columns, rows, 1, 10);
int[,] pos= new int [1,2]; 

PrintArray(array);
Console.WriteLine(" ");

FindPositionSmallElement(array,pos);

Console.Write("Индексы удаляемы строки и колонки ");
PrintArray(pos);
Console.WriteLine(" ");

TrimArray(pos[0,0],pos[0,1],array);

