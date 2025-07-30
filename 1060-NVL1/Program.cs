using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double n = 0;
        double pos =0;
        for (int i = 0; i < 6; i++)
        {
           n = double.Parse(Console.ReadLine());
            if (n != 0)
            {
                if (n > 0)
                {
                    pos = pos + 1;

                }
            }
        }
        Console.WriteLine(pos + " valores positivos");
    }

}