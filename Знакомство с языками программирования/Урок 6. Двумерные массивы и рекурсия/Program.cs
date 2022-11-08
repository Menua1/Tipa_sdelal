void PrintIntArray(int[] array) // печать массива, состоящего из int элементов
{
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) // ставим запятую после элемента, если это не последний элемент
            Console.Write(", ");
    }
    Console.WriteLine(" }");
}

int[] MakeRandomIntArray() // принимает целое число в качестве размера массива, верхнюю и нижнюю границу для генерации чисел, возвращает массив заданного размера, заполненный случайными числами от нижней до верхней границы чисел включительно.
{
    Console.Write("Введите размер массива >: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение для генерации >: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение для генерации >: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}


// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

bool ExistanceTriangle(double a, double b, double c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.Write("Введите размер стороны А >: ");
double sideA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите размер стороны B >: ");
double sideB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите размер стороны C >: ");
double sideC = Convert.ToDouble(Console.ReadLine());
bool resTask1 = ExistanceTriangle(sideA, sideB, sideC);
if (resTask1) Console.WriteLine("Треугольник существует!");
else Console.WriteLine("Треугольник не существует!");
// bool check = (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB);


// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
        copy[i] = array[i];

    return copy;
}

// int[] arrTask2 = MakeRandomIntArray();
// Console.Write("Первый массив: ");
// PrintIntArray(arrTask2);
// int[] copyArrTask2 = CopyArray(arrTask2);
// PrintIntArray(arrTask2);



// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

int[] Fibonacci(int n, int a, int b)
{
    int[] fibArray = new int[n];
    fibArray[0] = a;
    fibArray[1] = b;

    for (int i = 2; i < fibArray.Length; i++)
        fibArray[i] = fibArray[i-1] + fibArray[i-2];

    return fibArray;
}

// Console.Write("Введите размер ряда Фибоначчи >: ");
// int fibN = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите первое число ряда Фибоначчи >: ");
// int fibA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ряда Фибоначчи >: ");
// int fibB = Convert.ToInt32(Console.ReadLine());

// int[] arrTask3 = Fibonacci(fibN, fibA, fibB);
// PrintIntArray(arrTask3);