using System;

class Program
{
    static void PrintNumbers(int M, int N)
    {
        if (M <= N)
        {
            Console.WriteLine(M);
            PrintNumbers(M + 1, N);
        }
    }

    static void Main()
    {
        int M = 1;  // Установите значение M
        int N = 10;  // Установите значение N

        PrintNumbers(M, N);
    }
}