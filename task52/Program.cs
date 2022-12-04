// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = 3;
int columns = 4;
int[,] matrix = new int[rows, columns];
CreateMatrixRndInt(matrix);
PrintMatrix(matrix);




void CreateMatrixRndInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j], 4 }, "); //выводим последний элемент без запятой в конце!!!!!
            else
                Console.Write($"{matrix[i, j], 4} ");
        }
    Console.WriteLine("]"); 
    }
    
}

double[] arrayArithmetic = new double[matrix.GetLength(1)];

for (int i = 0; i < matrix.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        result += matrix[j, i];
    }
    arrayArithmetic[i] = Math.Round((result / matrix.GetLength(0)), 1);
}

 
void PrintArray(double[] matrix)
{
    Console.Write("[");
    for (int i = 0; i < matrix.Length; i++)
    {
        if(i < matrix.Length - 1) Console.Write($"{matrix[i], 4}, "); //выводим последний элемент без запятой в конце!!!!!
        else Console.Write($"{matrix[i],4} ");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Среднее арифметическое столбцов: ");
PrintArray(arrayArithmetic);
   




