/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

//Метод приёма числа на ввод
int GetNumberFromConsole(string message)
{
    Console.WriteLine(message);
    int result;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Нет слов. Длина - это число. Длина матрицы - натуральное число. А не это вот.");
        }
    }
    return result;
}
//Метод инициализации и спирального заполнения матрицы 
int[,] InitMatrix(int size)
{
    int[,] matrix = new int[size, size];
    int element = 01;
    int startIndex = 0;
    int endIndex = matrix.GetLength(0);

    while (startIndex < endIndex)
    {
        for (int j = startIndex; j < endIndex; j++)
        {
            matrix[startIndex, j] = element;
            element++;
        }
        startIndex ++;
        for (int i = startIndex; i < endIndex; i++)
        {
            matrix[i, endIndex-1] = element;
            element ++;
        }
        endIndex --;
        for (int j = endIndex-1; j > startIndex-2; j--)
        {
            matrix[endIndex, j] = element;
            element ++;            
        }
        for (int i = endIndex-1; i > startIndex-1; i--)
        {
            matrix[i, startIndex-1] = element;
            element ++;            
        }
    }
    return matrix;
}

//Метод печати массива с двузначными числами
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:d2} ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

int matrixSize = GetNumberFromConsole("Введите длину стороны квадратной матрицы");
int[,] matrix = InitMatrix (matrixSize);
PrintArray(matrix);