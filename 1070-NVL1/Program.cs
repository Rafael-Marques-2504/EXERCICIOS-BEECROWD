
        int x = int.Parse(Console.ReadLine());
        int contagem = 0;
        while (contagem < 6)
        {
            if (x % 2 == 0)
            {
             x++;
             Console.WriteLine(x);
             x = x + 2;
            }
            else
            {
        Console.WriteLine(x);
        x = x + 2;
            }
            contagem++;
                        
        }
    