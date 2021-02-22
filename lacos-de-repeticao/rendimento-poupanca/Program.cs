using System;

namespace rendimento_poupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Rendimentos na poupança ----");
            
            double rendimento = 0.1159;
            Console.WriteLine("Informe o valor a ser depositado: ");
            double investimento = double.Parse(Console.ReadLine());
            
            int contador = 1;
            int meses = 12;
            double rendimentoPoupanca = investimento;

            while (contador <= meses) 
            {
                rendimentoPoupanca = rendimentoPoupanca + investimento * rendimento;
                Console.WriteLine($"Após {contador} mês, você terá {rendimentoPoupanca}");
                contador++;
            }

            Console.WriteLine($"Após {meses} meses, o rendimento sobre o valor investido será de {rendimentoPoupanca - investimento}");
            
        }
    }
}
