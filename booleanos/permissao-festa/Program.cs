using System;

namespace permissao_festa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("---- Permissão para entrar nas Festas ---- \n \nInsira sua idade para verificação: ");
            
            int idade = int.Parse(Console.ReadLine());
            
            if (idade < 18)
            {
                Console.WriteLine("Está acompanhado com responsável? S - Sim / N - Não");
                string resposta = Console.ReadLine();
                if (resposta != "N") 
                {
                    Console.WriteLine("Pode entrar!");
                } else 
                {
                    Console.WriteLine("Entrada de menores apenas acompanhados de responsável maior de 18 anos!");
                }
            } else {
                Console.WriteLine("Pode entrar!");
            }
        }
    }
}
