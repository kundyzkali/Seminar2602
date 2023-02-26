// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {number}");

// int firstDigit = number / 100;
// int lastDigit = number % 10;

// int result = firstDigit * 10 + lastDigit;

// Console.Write($"Результат {result}");

int removeSecondDigit = RemoveSecondDigit(number);
Console.WriteLine($"Результат = {removeSecondDigit}");

int RemoveSecondDigit (int num) // num = number
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int result = firstDigit * 10 + lastDigit;
    return result;
}