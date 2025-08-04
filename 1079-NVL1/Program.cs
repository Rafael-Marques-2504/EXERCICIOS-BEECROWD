using System;

class URI
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] entrada;
        double n1 = 0;
        double n2 = 0;
        double n3 = 0;
        double mediaPonderada = 0;
        for (int i = 0; i < n; i++)
        {
            entrada = Console.ReadLine().Split(' ');
            n1 = double.Parse(entrada[0]);
            n2 = double.Parse(entrada[1]);
            n3 = double.Parse(entrada[2]);
            mediaPonderada = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
            Console.WriteLine(mediaPonderada.ToString("F1"));

        }



    }

}