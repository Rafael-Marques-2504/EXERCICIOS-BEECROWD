using System;

class URI
{
    static void Main(string[] args)
    {
        int x, y;

        while (true)
        {
            string[] partes = Console.ReadLine().Split(' ');
            x = int.Parse(partes[0]);
            y = int.Parse(partes[1]);

            if (x == y)
            {
                break; // encerra o loop
            }
            else if (x > y)
            {
                Console.WriteLine("Decrescente");
            }
            else
            {
                Console.WriteLine("Crescente");
            }
        }
    }
}
