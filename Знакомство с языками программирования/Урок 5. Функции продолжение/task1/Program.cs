// // int[] MakeUserArray() // заполнение массива пользовательскими целыми числами
// // {
// //     Console.Write("Введите размер массива >: ");
// //     int size = Convert.ToInt32(Console.ReadLine());

// //     while (size < 0)
// //     {
// //         Console.WriteLine("ОШИБКА! Размер массива не может быть отрицательным!");
// //         Console.Write("Введите размер массива (неотрицательное число) >: ");
// //         size = Convert.ToInt32(Console.ReadLine());
// //     }
// 
// //     int[] array = new int[size];

// //     if (size == 0)
// //         Console.WriteLine("Размер массива равен нулю, возвращаю пустой массив.");
// //     else
// //     {
// //         Console.WriteLine($"Создан массив с размером {size}. Давайте его заполним!");
// //         for (int i = 0; i < size; i++)
// //         {
// //             Console.Write($"Введите элемент массива ({i+1}/{size}) >: ");
// //             array[i] = Convert.ToInt32(Console.ReadLine());
// //         }
// //         Console.WriteLine($"Массив из {size} элемента(-ов) заполнен, возвращаю массив.");
        
// //     }

// //     return array;
// // }

// void PrintIntArray(int[] array) // печать массива, состоящего из int элементов
// {
//     Console.Write("{ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//         if (i < array.Length - 1) // ставим запятую после элемента, если это не последний элемент
//             Console.Write(", ");
//     }
//     Console.WriteLine(" }");
// }

// int[] MakeRandomIntArray(int size, int minValue, int maxValue) // принимает целое число в качестве размера массива, верхнюю и нижнюю границу для генерации чисел, возвращает массив заданного размера, заполненный случайными числами от нижней до верхней границы чисел включительно.
// {
//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// // =========================================================================

// // Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int[] MinusToPlus(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// // int[] rndArray1 = MakeRandomIntArray(10, -100, 100);
// // PrintIntArray(rndArray1);
// // int[] newArray1 = MinusToPlus(rndArray1);
// // PrintIntArray(newArray1);


// // Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// bool FindNumInArray(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num) return true;
//     }
//     return false;
// }

// int[] rndArray2 = MakeRandomIntArray(10, -100, 100);
// PrintIntArray(rndArray2);
// Console.Write("Введите число, которое будем искать в массиве: ");
// int findNum = Convert.ToInt32(Console.ReadLine());
// bool result1 = FindNumInArray(rndArray2, findNum);
// if (result1) Console.WriteLine($"Число {findNum} присустсвует в массиве.");
// else Console.WriteLine($"Число {findNum} отсутствует в массиве.");

// // Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [m,n].

// int FindAccordance(int[] array, int min, int max)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (min <= array[i] && array[i] <= max) count++;
//     }
//     return count;
// }

// // int[] rndArray3 = MakeRandomIntArray(12, -1000, 1000);
// // PrintIntArray(rndArray3);
// // Console.Write("Введите нижнюю границу поиска: ");
// // int minFind = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Введите верхнюю границу поиска: ");
// // int maxFind = Convert.ToInt32(Console.ReadLine());

// // int result2 = FindAccordance(rndArray3, minFind, maxFind);
// // Console.WriteLine($"Колличество эллементов массива, лежащих в отрезке от {minFind} до {maxFind} равно {result2}");