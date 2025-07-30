using System;

class URI
{

    static void Main(string[] args)
    {

        int contagem = 0;
        int pares = 0;
        int numero = 0;
        while (contagem < 5)
        {
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                pares++;
            }
            contagem++;

        }
        Console.WriteLine(pares + " valores pares");
    }
   
}

