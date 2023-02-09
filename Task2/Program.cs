// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

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

int[,] SwapRowsAndColsInArray(int[,] array)
{
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = array[j, i];
        }
    }
    return newArray;
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
int[,] newArray = SwapRowsAndColsInArray(array);
PrintArray(newArray);

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

// int[,] ReverseMatrix(int[,] matrix)
// {
//     int[,] matrix2 = new int[matrix.GetLength(1), matrix.GetLength(0)];
//     for (int i = 0; i < matrix2.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             matrix2[i, j] = matrix[j, i];
//         }
//     }
//     return matrix2;
// }

// int[,] matrix = FillMatrix(3, 5);
// PrintMatrix(matrix);
// System.Console.WriteLine();

// int[,] matrix2 = ReverseMatrix(matrix);
// PrintMatrix(matrix2);