using System;
using System.IO;

class Program
{
    static void Main()
    {
        Random random = new Random();
        using (StreamWriter sw = new StreamWriter("C:\\Users\\eduar\\Source\\Repos\\ConsoleTeste\\ConsoleTeste\\dataUMBILHÃO.txt"))
        {
            for (int i = 0; i < 1000000000; i++)
            {
                int numero = random.Next(1, 1001);
                sw.WriteLine(numero);
            }
        }
    }
}
