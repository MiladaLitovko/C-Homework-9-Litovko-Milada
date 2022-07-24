/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29
*/

Zadacha68();

void Zadacha68()
{
    Console.WriteLine("Введите число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    int akkermanFunction = RecursionWithAkkerman(M, N);
    Console.Write($"A({M},{N}) = {akkermanFunction}");

    int RecursionWithAkkerman(int M, int N)
    {
        if (M == 0) return N + 1;
        else if (N == 0) return RecursionWithAkkerman(M - 1, 1);
        else return RecursionWithAkkerman(M - 1, RecursionWithAkkerman(M, N - 1));
    }

}