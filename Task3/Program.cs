// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] FillArray(int[,] array, int minNumInArray, int maxNumInArray)
// {
//     Random rand = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rand.Next(minNumInArray, maxNumInArray);
//         }
//     }
//     return array;
// }

// int FindMax(int[,] array)
// {
//     int max = array[0, 0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] > max) max = array[i, j];
//         }
//     }
//     return max;
// }

// int FindMin(int[,] array)
// {
//     int min = array[0, 0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min) min = array[i, j];
//         }
//     }
//     return min;
// }

// void HowManyTimesAnElementOccursInArray(int[,] array, int min, int max)
// {
//     for (int k = min; k <= max; k++)
//     {
//         int count = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (k == array[i, j]) count++;
//             }
//         }
//         if (count > 0) Console.WriteLine($"Число {k} встречается {count} раз(а).");
//     }
// }

// Random rand = new Random();
// int rows = rand.Next(2, 11);
// int cols = rand.Next(2, 11);
// int[,] array = new int[rows, cols];

// int min = rand.Next(-50, 11);
// int max = rand.Next(min, min + 100);
// array = FillArray(array, min, max);
// PrintArray(array);
// System.Console.WriteLine();
// int maxElement = FindMax(array);
// int minElement = FindMin(array);

// HowManyTimesAnElementOccursInArray(array, minElement, maxElement);

// Решение с семинара

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}
//------------------------------------------------------------------------------------------------------
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
//----------------------------------------------------------------------------------------------
int[,] matr = FillMatrix(3, 4);
PrintMatrix(matr);
Console.WriteLine();
int[] result = new int[10];
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        result[matr[i, j]]++;
    }
}
Console.WriteLine(string.Join(" ", result));
Console.WriteLine();
for (int i = 0; i < result.Length; i++)
{
    if (result[i] != 0)
    { Console.WriteLine($"{i} встречается {result[i]} раз."); }
}