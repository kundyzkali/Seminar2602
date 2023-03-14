// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите целое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckingFiveCharacterNumber(number)) {
    Console.WriteLine(CheckingPalindrome(number) 
        ? $"Число {number} является палиндромом" 
        : $"Число {number} НЕ является палиндромом.");
} else {
    Console.WriteLine($"Число {number} не является пятизначным!");
}

bool CheckingFiveCharacterNumber (int num) 
{
    int numberIntegers = Math.Abs(num) / 10000;
    return numberIntegers > 0 && numberIntegers < 10 ? true : false;
}
 bool CheckingPalindrome (int num) 
{
    num = Math.Abs(num);
    int firstDigit = num / 10000;
    int secondDigit = num / 1000 % 10;
    int fourthDigit = num / 10 % 10;
     int lastDigit = num % 10;
     return firstDigit == lastDigit && secondDigit == fourthDigit ? true : false;
 }

// bool Comparison(int firstDigit, int secondDigit, int fourDigit, int fifthDigit);

// bool 
// { 
//     int FirstDigit = num / 10000;
//     int SecondDigit = ((num % 1000) - 10);
//     int FourDigit = num % 10;
//     int FifthDigit = ((num % 100) % 10) ;
//    return (firstDigit == secondDigit && secondDigit == fourDigit);
// }  
// if (Comparer1(num))
// {
//     Console.WriteLine("yes");
// }
// else {
//     Console.WriteLine("no");
// }

// // bool Comparison (int num);
// // int FirstDigit = Number / 10000;
// // int SecondDigit = ((Number % 1000)- 10);
// // int FourDigit = Number % 10;
// // int FifthDigit = ((Number % 100) % 10);
// // if (FourDigit == 0)
// // { 
// //     return {FirstDigit == FifthDigit} {SecondDigit == FourDigit};
// // }
// // if (Comparison(Number))
// //     {
// //         Console.WriteLine("Yes");
// //     }
// // else
// //     {
// //     Console.WriteLine("No");
// //       }

// // int quarter = Quarter(xCoordinate, yCoordinate);
// // string result = quarter > 0 ? $"Указанные координаты соответсыуют четверти -> {quarter}"
// //                             : "Введены не корректные коррдинаты";
// // Console.WriteLine(result);

// // int Quarter(int x, int y)
// // {
// //     if (x > 0 && y > 0) return 1;
// //     if (x < 0 && y > 0) return 2;
// //     if (x < 0 && y < 0) return 3;
// //     if (x > 0 && y < 0) return 4;
// //     return 0;
// // };



