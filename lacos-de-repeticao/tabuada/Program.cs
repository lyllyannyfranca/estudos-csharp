using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Tabuada ---- \n");
            Console.WriteLine("Informe o número que deseja calcular a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 10; i++) 
            {
                Console.WriteLine($"{numero} X {i} = {numero*i}");
            }
        }
    }
}
