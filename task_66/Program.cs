/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
 в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите начальное число: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конечное число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumFromMtoN(M, N));

int SumFromMtoN(int m, int n){    
if(m == n) return m;
return (m + SumFromMtoN(m + 1, n));
}


