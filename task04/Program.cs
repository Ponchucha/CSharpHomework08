/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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

//Метод инициализации и заполнения трёхмерной матрицы
int[,,] InitRandomMatrix(int m, int n, int q)
{
    int[,,] matrix = new int[m, n, q];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {            
            for (int k = 0; k < q; k++)
            {
                matrix[i, j, k] = rnd.Next(10, 100);                
            }
        }
    }
    return matrix;
}

//Метод печати трёхметной матрицы
void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int NumberOfRows = GetNumberFromConsole("Введите количество строк");
int NumberOfColumns = GetNumberFromConsole("Введите количество столбцов");
int NumberOfLayers = GetNumberFromConsole("Введите количество слоёв");
int[,,] array3d = InitRandomMatrix(NumberOfRows, NumberOfRows, NumberOfLayers);
PrintArray(array3d);