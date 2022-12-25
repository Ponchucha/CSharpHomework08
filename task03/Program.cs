/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
            Console.WriteLine("Это ни в какие ворота. Нужно натуральное число");
        }
    }
    return result;
}

//Метод инициализации и заполнения матрицы
int[,] InitRandomMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine($"Введите элемент {i+1} строки, {j+1} столбца.");            
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out matrix[i,j]))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("А, забыла уточнить, что матрица состоит из натуральных чисел. Попробуйте ещё раз.");
                }
            }
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
            Console.Write($"{matrix[i, j]:d2} ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

//Метод нахождения произведения двух матриц
int[,] GetMatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return resultMatrix;
}

int rowColumnNumber = GetNumberFromConsole("Введите количество столбцов первой матрицы и количество строк второй матрицы");
int rowNumberA = GetNumberFromConsole("Введите количество строк первой матрицы");
int columnNumberB = GetNumberFromConsole("Введите количество столбцов второй матрицы");
Console.WriteLine("Матрица А (сорри за ручной ввод, но иначе Вы замучаетесь проверять результат):");
int[,] matrixA = InitRandomMatrix(rowNumberA, rowColumnNumber);
Console.WriteLine("Матрица В (сорри за ручной ввод, но иначе Вы замучаетесь проверять результат):");
int[,] matrixB = InitRandomMatrix(rowColumnNumber, columnNumberB);
PrintArray(matrixA);
PrintArray(matrixB);
PrintArray(GetMatrixProduct(matrixA, matrixB));