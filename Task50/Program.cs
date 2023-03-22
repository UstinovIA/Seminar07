// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

int FindElement(int[,] matrix, int row, int column)
{
    if (row < matrix.GetLength(0) && column < matrix.GetLength(1)) return matrix[row, column];
    else return -1;
}

int[,] array2d = CreateMatrixRndInt(4, 5, 0, 30);
Console.WriteLine("Созданная матрица:");
PrintMatrix(array2d);
Console.WriteLine();
Console.Write("Введите номер строки элемента: ");
int numRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента: ");
int numColumn = Convert.ToInt32(Console.ReadLine());
int element = FindElement(array2d, numRow, numColumn);
string output = element != -1 ? $"Значение элемента на {numRow} строке, в {numColumn} столбце -> {element}" : "Такого элемента в массиве нет";
Console.WriteLine(output);