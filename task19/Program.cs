// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int Number = Convert.ToInt32(Console.ReadLine());

int FirstDigit = Number / 10000;
int SecondDigit = ((Number % 1000)- 10);
int FourDigit = Number % 10;
int FifthDigit = ((Number % 100) % 10);

bool Comparison (int num)
{
    return {FirstDigit == FifthDigit} {SecondDigit == FourDigit};
}
if (Comparison(Number))
    {
        Console.WriteLine("Yes");
    }
else
    {
    Console.WriteLine("No");
      }

// int quarter = Quarter(xCoordinate, yCoordinate);
// string result = quarter > 0 ? $"Указанные координаты соответсыуют четверти -> {quarter}"
//                             : "Введены не корректные коррдинаты";
// Console.WriteLine(result);

// int Quarter(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     return 0;
// };



