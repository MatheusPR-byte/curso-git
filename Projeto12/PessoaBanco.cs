using System;
using System.Globalization;
namespace Projeto12 {
    internal class PessoaBanco {

        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public PessoaBanco(int conta, string titular) {
            Conta = conta;
            Titular = titular;
            Saldo = 0;
        }
        public PessoaBanco(int conta, string titular, double depositoInicial) : this(conta, titular) {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5;
        }

        public override string ToString() {
            return "Conta " 
                + Conta
                + ", Titular: " 
                + Titular 
                + ", Saldo: $ " 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
