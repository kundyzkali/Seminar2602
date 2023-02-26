// Напишите программу, которая принимает 
// 1. на вход цифру, обозначающую день недели,
// 2.и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)  {  
 Console.WriteLine(CheckWeekend(number) ? "Выходной" : "Рабочий день");
} else {
    Console.WriteLine($"Число {number} не является днем недели!");
}
bool CheckWeekend (int num) {
    return Math.Abs(num) == 6 || Math.Abs(num) == 7 ? true : false;
}
