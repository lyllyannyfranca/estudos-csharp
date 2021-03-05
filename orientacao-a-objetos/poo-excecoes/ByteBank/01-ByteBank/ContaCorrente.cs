using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public int Agencia { get; }
        
        public int Numero { get; private set; }
        
        public double Saldo { get; private set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }

        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public static int TotalDeContasCorrentes { get; private set; }

        public static int TaxaDeOperacao { get; private set; }

        public ContaCorrente(int agencia, int numeroDaConta)
        {
            Titular = new Cliente();

            if (agencia <= 0)
            {
                throw new ArgumentException($"O argumento {nameof(agencia)} deve ser maior que 0!");
            }

            if (numeroDaConta <= 0)
            {
                throw new ArgumentException($"O argumento {nameof(numeroDaConta)} deve ser maior que 0!");
            }

            Agencia = agencia;
            Numero = numeroDaConta;

            TotalDeContasCorrentes++;

            TaxaDeOperacao = 30 / TotalDeContasCorrentes;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException($"Valor de saque não pode ser negativo, {nameof(valor)}");
            }

            if (Saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException($"Valor inválido para transferência. {nameof(valor)}");
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException e)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada!", e);
            }
            contaDestino.Depositar(valor);
        }
    }
}
