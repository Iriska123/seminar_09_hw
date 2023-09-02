/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
 в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


Console.WriteLine("Введите число: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(Answer(M, N));

string SumFromMtoN(int m, int n){     //// 2 3 4
int sum = 0;
if(m == n) return (sum + m).ToString();
return (sum + m", "+ SumFromMtoN(m + 1, n));
}

