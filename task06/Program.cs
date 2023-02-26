// Напишите программу, которая 
// на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите целое число: ");
string str = Console.ReadLine();

int number = Convert.ToInt32(str);
int lastDigit = number % 2;
if (lastDigit == 0) {
Console.WriteLine($"четное число {number}");    
} else {
    Console.WriteLine($"НЕ четное число {number}");
}




