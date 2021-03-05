using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ByteBank
{
    class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }

        public double ValorSaque { get; }

        public SaldoInsuficienteException() { }

        public SaldoInsuficienteException(string mensagem) 
            : base(mensagem) { }

        public SaldoInsuficienteException(double saldo, double valorSaque) 
            : this ($"Tentativa de saque de R$ {valorSaque} com saldo de {saldo}.")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
    }
}
