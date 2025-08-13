using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        string[] entrada1 = Console.ReadLine().Split(' ');
        string[] entrada2 = Console.ReadLine().Split(' ');
        double codigoPeca1 = double.Parse(entrada1 [0],CultureInfo.InvariantCulture);
        double numeroPecas1 = double.Parse(entrada1[1], CultureInfo.InvariantCulture);
        double valorUnitario1 = double.Parse(entrada1[2], CultureInfo.InvariantCulture);
        double codigoPeca2 = double.Parse(entrada2[0], CultureInfo.InvariantCulture);
        double numeroPecas2 = double.Parse(entrada2[1], CultureInfo.InvariantCulture);
        double valorUnitario2 = double.Parse(entrada2[2], CultureInfo.InvariantCulture);
        double total = numeroPecas1 * valorUnitario1 + numeroPecas2 * valorUnitario2;
        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
    }

}