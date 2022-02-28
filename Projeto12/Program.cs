using Projeto12;
using System;
using System.Globalization;
class Program {
    static void Main(string[] args) {

        PessoaBanco conta;

        Console.Write("Entre o número da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();
        Console.Write("Haverá depósito inicial (s/n)? ");
        char logica = char.Parse(Console.ReadLine());

        if (logica == 's' || logica == 'S') {
            Console.Write("Entre o valor de depósito inicial: ");
            double depositoInicio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new PessoaBanco(numero, titular, depositoInicio);
        }
        else {
            conta = new PessoaBanco(numero, titular);
        }

        Console.WriteLine("Dados da conta: ");
        Console.WriteLine(conta);

        Console.Write("Entre um valor para depósito: ");
        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Deposito(quantia);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta);

        Console.Write("Entre um valor para saque: ");
        quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(quantia);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta);

        Console.WriteLine("sururu");

    }
}
