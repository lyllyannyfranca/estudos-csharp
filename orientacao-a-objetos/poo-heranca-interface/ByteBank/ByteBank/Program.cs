using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            
            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "123.456.987-10";
            carlos.Salario = 2000;

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "321.654.789-01";
            roberta.Salario = 5000;

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);

            Console.WriteLine($"Total de bonificações: {gerenciador.GetTotalBonificacao()}");

            Console.WriteLine("=================================================== \n");

            Funcionario teste = new Diretor();
            teste.Nome = "Teste";
            teste.CPF = "000.000.000-00";
            teste.Salario = 1500;

            gerenciador.Registrar(teste);

            Console.WriteLine($"Teste de referencia: {teste.GetBonificacao()}");
            Console.WriteLine($"Teste de referencia: {gerenciador.GetTotalBonificacao()}");
        }
    }
}
