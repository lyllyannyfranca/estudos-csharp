using System;

namespace multiplos_de_tres
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} é múltiplo de 3.");
                }
            }
        }
    }
}
