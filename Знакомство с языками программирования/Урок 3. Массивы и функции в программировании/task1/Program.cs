// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void QuartToXY(int quart)
{
    if (quart == 1)
    {
        Console.WriteLine($"В четверти {quart} находятся точки с положительными координатами X и Y.");
    }
    else if (quart == 2)
    {
        Console.WriteLine($"В четверти {quart} находятся точки с отрицательными координатами X и положительными координатами Y.");
    }
    else if (quart == 3)
    {
        Console.WriteLine($"В четверти {quart} находятся точки с отрицательными координатами X и Y.");
    }
    else if (quart == 4)
    {
        Console.WriteLine($"В четверти {quart} находятся точки с положительными координатами X и отрицательными координатами Y.");
    }
    else
        Console.WriteLine($"Четверть {quart} не является допустимой.");
}

Console.Write("Введите номер четверти: ");
int quart = Convert.ToInt32(Console.ReadLine());
QuartToXY(quart);


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
double DistanceBetwenPoints(double ax, double ay, double bx, double by)
{
    return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));
}

Console.Write("Введите коордитану X точки A: ");
double ax = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коордитану Y точки A: ");
double ay = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коордитану X точки B: ");
double bx = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коордитану Y точки B: ");
double by = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между точкой A({ax}, {ay}) и точкой B({bx}, {by}) равно {DistanceBetwenPoints(ax, ay, bx, by)}.");

// Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.

void QuartsOfNumbers(int n)
{
    int count = 1;
    while (count <= n)
    {
        Console.Write($"{Math.Pow(count, 2)} ");
        count++;
    }
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
QuartsOfNumbers(n);