using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(863, 8634561) ;

            conta.Titular.Nome = "Gabriela";
            conta.Titular.CPF = "123.456.789-00";
            conta.Titular.Profissao = "Desenvolvedora C#";

            Console.WriteLine($"Titular: {conta.Titular.Nome}");
            Console.WriteLine($"Agência: {conta.Agencia}");
            Console.WriteLine($"Número da conta: {conta.Numero}");
            Console.WriteLine($"Saldo: {conta.Saldo}");

            Console.WriteLine("=================================== \n");
            
            conta.Depositar(200);

            Console.WriteLine($"Novo saldo da Gabriela: {conta.Saldo}");

            Console.WriteLine("=================================== \n");

            ContaCorrente conta2 = new ContaCorrente(863, 8631236);

            conta2.Titular.Nome = "Bruno";
            conta2.Titular.CPF = "123.456.987-10";
            conta2.Titular.Profissao = "Engenheiro Civil";

            Console.WriteLine($"Titular: {conta2.Titular.Nome}");
            Console.WriteLine($"Agência: {conta2.Agencia}");
            Console.WriteLine($"Número da Conta: {conta2.Numero}");
            Console.WriteLine($"Saldo: {conta2.Saldo}\n");
            
            conta.Transferir(100, conta2);

            Console.WriteLine($"Novo saldo de Gabriela: {conta.Saldo}\n");
            Console.WriteLine($"Novo saldo de Bruno: {conta2.Saldo}\n");

            Console.WriteLine($"Total de Contas Correntes abertas: {ContaCorrente.TotalDeContasCorrentes}");
        }
    }
}
