using System;

class URI
{

    static void Main(string[] args)
    {
        int n = 0;
        int neg = 0;
        int pos = 0;
        int par = 0;
        int imp = 0;
        for (int i = 0; i < 5; i++)
        {

            n = int.Parse(Console.ReadLine());
            if (n > 0) { pos++; }
            if (n < 0) { neg++; }
            if (n % 2 == 0) { par++; }
            if (n % 2 != 0) { imp++; }

        }
        Console.WriteLine(par + " valor(es) par(es)");
        Console.WriteLine(imp + " valor(es) impar(es)");
        Console.WriteLine(pos + " valor(es) positivo(s)");
        Console.WriteLine(neg + " valor(es) negativo(s)");
    }
}