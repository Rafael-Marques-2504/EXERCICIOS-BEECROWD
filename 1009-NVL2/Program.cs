using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        string nome = Console.ReadLine();
        double SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double TotalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double Total = SalarioFixo + TotalVendas * 0.15;
        Console.WriteLine("TOTAL = R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));



     

    }

}