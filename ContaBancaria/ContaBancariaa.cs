using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancaria
{
    class ContaBancariaa
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public ContaBancariaa (int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancariaa(int numero, string titular, double depositoIncial) : this(numero, titular) //this para aproveitar os dados de cima
        {
            Deposito(depositoIncial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.00;
        }


        public override string ToString()
        {
            return "Conta "
            + Numero
            + ", Titular: "
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
