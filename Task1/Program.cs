// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] FillArray(int[,] array, int minNumInArray, int maxNumInArray)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(minNumInArray, maxNumInArray);
        }
    }
    return array;
}

int[,] SwapTheFirstAndLastLinesInArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = array[0, i];
        array[0, i] = temp;
    }
    return array;
}

Random rand = new Random();
int rows = rand.Next(2, 11);
int cols = rand.Next(2, 11);
int[,] array = new int[rows, cols];

int min = rand.Next(-50, 11);
int max = rand.Next(min, min + 100);
array = FillArray(array, min, max);

PrintArray(array);
System.Console.WriteLine();
SwapTheFirstAndLastLinesInArray(array);
PrintArray(array);

// Решение с семинара

// int[,] FillMatrix(int rows, int cols)
// {
//     int[,] matr = new int[rows, cols];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matr[i, j] = rand.Next(1, 10);
//         }
//     }
//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             System.Console.Write(matr[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void ReverseMatrix(int[,] matrix)
// {
//     int temp = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         temp = matrix[0, i];
//         matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//         matrix[matrix.GetLength(0) - 1, i] = temp;
//     }
// }

// int[,] matrix = FillMatrix(7, 4);
// PrintMatrix(matrix);
// System.Console.WriteLine();
// ReverseMatrix(matrix);
// PrintMatrix(matrix);