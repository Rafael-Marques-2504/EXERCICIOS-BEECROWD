using System;

class URI
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int resultado = 0;
        for (int i = 1; i <= 10; i++)
        {
            resultado = i * n;
            Console.WriteLine(i + " x " + n + " = " + resultado);


        }

    }
}