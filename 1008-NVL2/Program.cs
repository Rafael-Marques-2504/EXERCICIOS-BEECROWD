using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)

    {
        int NumeroFuncionario = int.Parse(Console.ReadLine());
        double HorasTrabalhadas = double.Parse(Console.ReadLine());
        double ValorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double salario = HorasTrabalhadas * ValorHora;
        Console.WriteLine("NUMBER = " + NumeroFuncionario);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
    }

}