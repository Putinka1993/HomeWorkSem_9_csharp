// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число (от) M ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число (до) N ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"{SumNum(m, n)}");


int SumNum(int mS, int nE){
    
    if (mS == nE) return nE;
    return (mS += SumNum(mS+1, nE));
}
    