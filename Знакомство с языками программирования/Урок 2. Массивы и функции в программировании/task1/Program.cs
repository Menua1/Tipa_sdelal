// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int DeleteSecondDigit(int num)
{
    int result;
    int ed = num % 10;
    int hun = num / 100;
    result = hun * 10 + ed;
    return result;
}

int randomNum = new Random().Next(100, 1000);
int twoDigitNumber = DeleteSecondDigit(randomNum);
Console.WriteLine($"Number {randomNum} without middle digit is {twoDigitNumber}");
*/


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
// a и b - инфо от пользователя(тоже int)
bool MultiplesOfAAndB(int num, int a, int b)
{
    if (num % a == 0 && num % b == 0)
        return true;
    else
        return false;
}

Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("input number a: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("input number b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

bool result = MultiplesOfAAndB(number, numberA, numberB);

if (result)
    Console.WriteLine($"Number {number} multiples of {numberA} and {numberB}.");
else
    Console.WriteLine($"Number {number} does not multiple of {numberA} and {numberB}.");