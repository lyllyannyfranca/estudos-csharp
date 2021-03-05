using System;
using System.IO;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();            
            }
            catch(Exception )
            {
                Console.WriteLine("CATH NO MÉTODO MAIN");
            }
        }

        public static void CarregarContas()
        {
            //Sugar Sintax
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
            {
                for(int i=0; i <= 3; i++)
                {
                    leitor.LerProximaLinha();
                }
            }
            
            //Código abaixo é a mesma coisa que do código acima
            
            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");
                
            //    for(int i=0; i <= 3; i++)
            //    {
            //        leitor.LerProximaLinha();
            //    }
            //}
            //catch(IOException e)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
            //}
            //finally
            //{
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }

        public static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 3455);
                ContaCorrente conta2 = new ContaCorrente(567, 2135);

                conta.Depositar(400);
                Console.WriteLine($"Novo saldo após depósito: {conta.Saldo}\n");

                conta.Sacar(100);
                Console.WriteLine($"Novo saldo após saque: {conta.Saldo}\n");

                conta.Transferir(200, conta2);
                Console.WriteLine($"Conta 1 -> Novo Saldo após realizar a transferência: {conta.Saldo}\n");
                Console.WriteLine($"Conta 2 -> Novo Saldo após recebimento da transferência: {conta2.Saldo}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ParamName);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                
                Console.WriteLine("\n Informações da INNER EXCEPTION (Exceção interna) \n");
                
                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
        }
    }
}
