// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void FindIndex(int[,] matrix, int x, int y)
{
     for (int i =0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
           if(i == x && l == y)
           {
            Console.WriteLine(matrix[i,l]);
           }                      
    
        }
    
    }
    Console.WriteLine("\nТакого элемента не существует");
}

int rows = new Random().Next(2, 10 + 1);
int columns = new Random().Next(2, 10 + 1);

int[,] array = FillArray(columns, rows, 1, 10);

Console.WriteLine("Введите индексы элемента массива:");
int indexX = Convert.ToInt32(Console.ReadLine());
int indexY = Convert.ToInt32(Console.ReadLine());

PrintArray(array);
Console.WriteLine(" ");
FindIndex(array, indexX, indexY);