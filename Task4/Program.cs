// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Наименьший элемент - 1, на выходе получим следующий массив:

// 9 2 3
// 4 2 4
// 2 6 7

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

int[] FindMinCoords(int[,] array)
{
    int min = array[0, 0];
    int[] minCoords = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minCoords[0] = i;
                minCoords[1] = j;
            }

        }
    }
    return minCoords;
}

// int[,] DeleteRowAndColumnWithTheSmallestArrayElement(int[,] array, int[] minCoords)
// {
//     int[] elements = new int[(array.GetLength(0) - 1) * (array.GetLength(1) - 1)];
//     int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     int k = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i != minCoords[0] && j != minCoords[1])
//             {
//                 elements[k] = array[i, j];
//                 k++;
//             }
//         }
//     }
//     int n = 0;
//     for (int l = 0; l < newArray.GetLength(0); l++)
//     {
//         for (int m = 0; m < newArray.GetLength(1); m++)
//         {
//             newArray[l, m] = elements[n];
//             n++;
//         }
//     }
//     return newArray;
// }

int[,] DeleteRowAndColumnWithTheSmallestArrayElement(int[,] array, int[] minCoords)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int l = 0;
        if (i == minCoords[0]) continue;
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == minCoords[1]) continue;
                {
                    newArray[k, l] = array[i, j];
                }
                l++;
            }
        }
        k++;
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
int[] minCoords = FindMinCoords(array);
int[,] newArray = DeleteRowAndColumnWithTheSmallestArrayElement(array, minCoords);
PrintArray(newArray);

// Решение с семинара

// int[,] FillMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matr = new int[rows, cols];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matr[i, j] = rand.Next(0, 10);
//         }
//     }
//     return matr;
// }
// //------------------------------------------------------------------------------------------------------
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
// //---------------------------------------------------------------------------

// int[,] matr = FillMatrix(4, 4);
// PrintMatrix(matr);
// int min = matr[0, 0];
// int minIndexI = 0;
// int minIndexJ = 0;
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (matr[i, j] < min)
//             {
//                 min = matr[i, j];
//                 minIndexI = i;
//                 minIndexJ = j;
//             }
//         }
//     }
// }
// int[,] result = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
// int countI = 0;
// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     int countJ = 0;
//     if (i == minIndexI) continue;
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         if (j == minIndexJ) continue;
//         result[countI, countJ] = matr[i, j];
//         countJ++;
//     }
//     countI++;
// }
// System.Console.WriteLine();
// PrintMatrix(result);