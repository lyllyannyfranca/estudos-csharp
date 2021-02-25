using System;

namespace excecao_divisao_por_zero
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Metodo();
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Não é possível realizar divisão por 0!");
            }
            catch (Exception excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }
        }

        public static int Dividir(int numero, int divisor) 
        {
            //ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);
            try 
            {
                return numero / divisor;
            }
            catch (Exception) 
            {
                Console.WriteLine($"Exceção com número = {numero} e divisor = {divisor}.");
                throw;
            }
        }

        static void Metodo() 
        {
            TestaDivisao(0);
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}
