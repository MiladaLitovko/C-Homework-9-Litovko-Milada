/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Zadacha66();

void Zadacha66()
{
    Console.WriteLine("Введите число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    int Z = M;
    Recursion(Z, N);
    Console.WriteLine($"Сумма элементов в промежутке от {M} до {N} равна: {sum}");
    
    void Recursion(int Z, int N)
    {
      if (Z > N) return;
      sum = sum + Z;
      Z++;
      Recursion(Z, N);
    }
}