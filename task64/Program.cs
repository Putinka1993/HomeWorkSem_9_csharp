// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число: ");
int EnNum = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNum(EnNum, 1));

string PrintNum(int EndNumber, int StartNumber){
    if (EndNumber == StartNumber) return StartNumber.ToString();
    return (EndNumber + ", " + PrintNum(EndNumber-1, StartNumber));
}