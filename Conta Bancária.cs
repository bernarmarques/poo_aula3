using System;

class ContaBancaria
{
    public string NumeroConta { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; private set; }

    public ContaBancaria(string numeroConta, string titular, double saldoInicial)
    {
        NumeroConta = numeroConta;
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor:F2} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser positivo.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso.");
        }
        else if (valor > 0)
        {
            Console.WriteLine("Saldo insuficiente para o saque.");
        }
        else
        {
            Console.WriteLine("O valor do saque deve ser positivo.");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: R${Saldo:F2}");
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria("123456", "João Silva", 1000.0);
        
        conta.ExibirSaldo();
        conta.Depositar(500);
        conta.ExibirSaldo();
        conta.Sacar(300);
        conta.ExibirSaldo();
    }
}
