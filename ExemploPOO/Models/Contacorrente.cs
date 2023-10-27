using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Contacorrente
    {
        public Contacorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = NumeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
            Console.WriteLine("Saldo insuficiente!");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo disponível: " + saldo);

        }
    }
}