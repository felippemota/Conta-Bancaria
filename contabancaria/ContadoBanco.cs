
using System;
using System.IO;
using System.Globalization;
namespace SistemadeBanco
{
    public class ContaBancaria
    {

        public string Nome { get; set; }
        public int Numero { get; private set; }
        public float Saldo { get; private set; }


        public ContaBancaria(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;

        }
        public ContaBancaria(int numero, string nome, float depositoinicial)
        {
            Nome = nome;
            Numero = numero;
            Saldo = depositoinicial;
        }


        public void Deposito(double quantia)

        {
            Saldo += (float)quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= (float)quantia + 5;
        }



        public override string ToString()
        {
            return "Conta: "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }


}
