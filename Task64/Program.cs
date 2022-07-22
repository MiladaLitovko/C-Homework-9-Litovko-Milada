/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N, кратные трём.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

Zadacha64();

void Zadacha64()
{
    Console.WriteLine("Введите число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    Recursion(M, N);
    
    void Recursion(int M, int N)
    {
      if (M > N) return;
      if(M % 3 == 0)
      {
        Console.Write(M + " ");
      }
      M++;
      Recursion(M, N);
    }
}

