// Напишите программу, которая принимает 
// 1.на вход трёхзначное число и 
// 2.на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {number}");
// int firstDigit = number / 10; 
// int secondDigit = firstDigit % 10;
// int result = secondDigit;
// Console.Write($"Результат {result}");

int findSecondDigit = FindSecondDigit(number);
int FindSecondDigit (int num) {
    return (Math.Abs(num) / 10) % 10;
}
Console.WriteLine($"Результат = {findSecondDigit}");

// int findSecondDigit (int num) // num = number
// {
//     int firstDigit = num / 10;
//     int secondDigit = firstDigit % 10;
//     int result = secondDigit;
//     return result;
// }
