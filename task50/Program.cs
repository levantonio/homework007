// Задача 50. Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого элемента в массиве нет(поиск по индексу)

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; //строка и колонка

    Random rnd = new Random(); //надо делать так
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            matrix[i,j] = rnd.Next(min, max + 1); //i = индекс массива
        }
    }
    return matrix;
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


Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер колонки: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] arr2D = CreateMatrixRndInt(rows, columns, 1, 9);
PrintMatrix(arr2D);
Console.Write("Введите номер строки: ");
int rowsfind = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер колонки: ");
int columnsfind = Convert.ToInt32(Console.ReadLine());
if(rowsfind > rows && columnsfind > columns) Console.WriteLine($"Элемента с позицией {rowsfind},{columnsfind} не существует");
else
{
    object arr = arr2D.GetValue(rowsfind, columnsfind);
    Console.WriteLine(arr);
}
    



   




