using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        private int _agencia;

        public int Agencia {
            get 
            {
                return _agencia;
            }
            private set 
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            } 
        }
        
        public int Numero { get; private set; }

        private double _saldo;
        
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            private set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public static int TotalDeContasCorrentes { get; private set; }

        public ContaCorrente(int agencia, int numeroDaConta)
        {
            Titular = new Cliente();
            Agencia = agencia;
            Numero = numeroDaConta;
            Saldo = 100;
            TotalDeContasCorrentes++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
