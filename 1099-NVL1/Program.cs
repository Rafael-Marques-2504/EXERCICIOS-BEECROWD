using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int X = int.Parse(entrada[0]);
            int Y = int.Parse(entrada[1]);

            int menor = Math.Min(X, Y);
            int maior = Math.Max(X, Y);

            int soma = 0;

            for (int j = menor + 1; j < maior; j++)
            {
                if (j % 2 != 0)
                {
                    soma += j;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
