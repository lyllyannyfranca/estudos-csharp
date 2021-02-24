using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            UsarSistema();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("321.654.789-01");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta rosa = new GerenteDeConta("734.123.580-47");
            rosa.Nome = "Rosa";
            rosa.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(rosa, "abc");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Auxiliar carlos = new Auxiliar("123.456.987-10");
            carlos.Nome = "Carlos";

            gerenciador.Registrar(carlos);

            Desenvolvedor guilherme = new Desenvolvedor("015.345.854-19");
            guilherme.Nome = "Guilherme";

            gerenciador.Registrar(guilherme);

            Designer gabriela = new Designer("890.476.123.56");
            gabriela.Nome = "Gabriela";

            gerenciador.Registrar(gabriela);

            GerenteDeConta rosa = new GerenteDeConta("734.123.580-47");
            rosa.Nome = "Rosa";

            gerenciador.Registrar(rosa);

            Diretor roberta = new Diretor("321.654.789-01");
            roberta.Nome = "Roberta";

            gerenciador.Registrar(roberta);

            Console.WriteLine($"Total de Funcionarios: {Funcionario.TotalDeFuncionarios}");
            Console.WriteLine($"Total de bonificações do mês: {gerenciador.GetTotalBonificacao()}");

            Console.WriteLine("=================================================== \n");
        }
    }
}
