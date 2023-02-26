// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

//string str = Console.ReadLine();
Console.WriteLine("Введите трехзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number % 10;
Console.WriteLine($"Последняя цифра числа: {lastDigit}");
