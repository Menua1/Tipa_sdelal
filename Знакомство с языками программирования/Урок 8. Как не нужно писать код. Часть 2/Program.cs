void Print2DArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(", ");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(",");
        else Console.WriteLine(".");
    }
}
int[,] Create2DArrayRandomInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
void ChangeArray(int[,] array)
{
    int firstRow = 0;
    int lastRow = array.GetLength(0) - 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[firstRow, j];
        array[firstRow, j] = array[lastRow, j];
        array[lastRow, j] = temp;
    }
}
/*
int [,] array1 = Create2DArrayRandomInt(4, 4, 1, 10);
Print2DArrayInt(array1);
System.Console.WriteLine();
ChangeArray(array1);
Print2DArrayInt(array1);
*/

// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] NewSmallArray(int[,] array)
{
    int minValueRow = 0;
    int minValueColumn = 0;
    int [,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < array[minValueRow, minValueColumn])
            {
                array[minValueRow, minValueColumn] = array[i,j];
                minValueRow = i;
                minValueColumn = j;
            }
        }
    }
    Console.WriteLine($"Minimal element = {array[minValueRow,minValueColumn]}[{minValueRow}, {minValueColumn}]");
    Console.WriteLine();

    for (int i = 0, x = 0; i < array.GetLength(0); x++, i++)
    {
        if(i == minValueRow)
        {
            x--;
            continue;
        }

        for (int j = 0, y = 0; j < array.GetLength(1); y++, j++)
        {
            if(j == minValueColumn)
            {
                y--;
                continue;
            }
            newArray[x, y] = array[i, j];
        }
    }
    return newArray;
}

int [,] array2 = Create2DArrayRandomInt(4, 4, 1, 10);
Print2DArrayInt(array2);
Console.WriteLine();
int[,] array3 = NewSmallArray(array2);
Print2DArrayInt(array3);