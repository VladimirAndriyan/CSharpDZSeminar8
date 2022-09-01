// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();
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
int[,] firstMatrix = FillMatrix(m, n, 0, 9);
int[,] secondMatrix = FillMatrix(m, n, 0, 9);
Console.WriteLine($"Первая матрица ");
PrintMatrix(firstMatrix);
Console.WriteLine($"Вторая матрица ");
PrintMatrix(secondMatrix);
Console.WriteLine();
int[,] MatrixProduct(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrixOne[i, j] * matrixTwo[i, j];
        }
    }
    return matrix;
}
int[,] newMatrix = MatrixProduct(firstMatrix, secondMatrix);
PrintMatrix(newMatrix);