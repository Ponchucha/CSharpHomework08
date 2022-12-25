/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

//Метод инициализации и заполнения матрицы со случайной размерностью
int[,] InitRandomMatrix()
{
    Random rnd = new Random();
    int[,] matrix = new int[rnd.Next(3,7), rnd.Next(3,7)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 99);
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

//метод сортировки строк матрицы
void SortRows(int[,]matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i,j] = matrix[i,j];
        }
    }    
    
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {   
        bool rowSorted = false;
        int rowLength = newMatrix.GetLength(1);     
        while (!rowSorted)
        {            
            rowSorted = true;

            for (int j = 1; j < rowLength; j++)
            {
                if (newMatrix[i,j] > newMatrix[i,j-1])
                {
                    int temp = newMatrix[i,j-1];
                    newMatrix[i,j-1] = newMatrix[i,j];
                    newMatrix[i,j] = temp;
                    rowSorted = false;                    
                }
            }
            rowLength --;       
        }
    }
    PrintArray(newMatrix);  
}



int [,] matrix = InitRandomMatrix();
PrintArray(matrix);
SortRows(matrix);


