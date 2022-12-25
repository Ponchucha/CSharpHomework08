/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
//Метод инициализации и заполнения матрицы со случайной размерностью
int[,] InitRandomMatrix()
{
    Random rnd = new Random();
    int[,] matrix = new int[rnd.Next(3,5), rnd.Next(3,5)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 9);
        }
    }
    return matrix;
}

//Метод печати массива
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

//Метод нахождения номера строки с максимальной суммой элементов
int GetRowNumber (int[,]matrix)
{
    int maxRowNumber = 0;    
    int maxRowSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i,j];
        }
        if (rowSum > maxRowSum)
        {
            maxRowSum = rowSum;
            maxRowNumber = i;
        }
    }
    return maxRowNumber+1;
}

int[,] matrix = InitRandomMatrix();
PrintArray(matrix);
Console.WriteLine($"Сумма элементов максимальна в {GetRowNumber(matrix)} строке");

