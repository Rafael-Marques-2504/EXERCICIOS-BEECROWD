using System;

class URI
{

    static void Main(string[] args)
    {
        int i = 1;
        int j = 7;
        for (i = 1; i <= 9; i = i + 2)
        {
            for (j = 7; j >= 5; j--)
            {
                Console.WriteLine("I=" + i + " J=" + j);
            }
        }
    }

}