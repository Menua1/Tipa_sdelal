void Print2DIntArray(int[,] array) // печать массива, состоящего из int элементов
{
    // Console.Write("{ ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1) // ставим запятую после элемента, если это не последний элемент в строке
                Console.Write(", ");
        }
        if (i < array.GetLength(0) - 1) // ставим запятую после последнего элемента в строке, если это не последняя строка, иначе точку.
                Console.WriteLine(",");
        else Console.WriteLine(".");
    }
    // Console.WriteLine(" }");
}

int [,] Create2DRandomArray()
{
    Console.Write("Введите количество строк >: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов >: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное возможное значение >: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное возможное значение >: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

int[,] CreateTask1Array()
{
    Console.Write("Введите количество строк >: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов >: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}

// Print2DIntArray(CreateTask1Array());


// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

void Task2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
        for (int j = 0; j < array.GetLength(1); j+=2)
            array[i,j] *= array[i,j];
}

// int[,] task2Array = Create2DRandomArray();
// Console.WriteLine("Исходный массив");
// Print2DIntArray(task2Array);

// Task2(task2Array);
// Console.WriteLine("Массив после преобразования");
// Print2DIntArray(task2Array);


//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int Task3(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if(i==j) result += array[i,j];
    return result;
}

int Task3v2(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        result += array[i,i];
    return result;
}

int[,] task3Array = Create2DRandomArray();
Console.WriteLine("Исходный массив");
Print2DIntArray(task3Array);
int task3res = Task3v2(task3Array);
Console.WriteLine($"Сумма элементов на главной диагонали равна {task3res}.");