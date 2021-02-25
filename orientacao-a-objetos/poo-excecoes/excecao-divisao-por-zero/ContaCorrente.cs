using System;

namespace excecao_divisao_por_zero
{
    class ContaCorrente
    {
        public int Agencia {get; private set; }
        public int Numero {get; private set; }
        public double Saldo { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            Saldo = 0;
        }

        public void Depositar(double valor)
        {
            if(valor < 1)
            {
                return;
            }

            Saldo = valor; 
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                return;
            }

            Saldo -= valor;
        }
    }
        
}
