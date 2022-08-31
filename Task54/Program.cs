// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите число строк m ");
int m = Convert.ToInt32(Console.ReadLine());//число строк
Console.Write("Введите число стобцов n ");
int n = Convert.ToInt32(Console.ReadLine());//число столбцов
int[,] matrix = FillMatrix(m, n, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int maxi = i;
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int maxj = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[maxi, maxj]) maxj = k;
            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[maxi, maxj];
            matrix[maxi, maxj] = temp;
        }
    }
}
SortMatrix(matrix);
PrintMatrix(matrix);