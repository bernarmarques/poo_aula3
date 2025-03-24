using System;

class Aluno
{
    public int RA { get; set; } = 48872;
    public string Nome { get; set; } = "Bernardo Marques";
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public double NotaFinal { get; private set; }

    public void ReceberDados()
    {
        Console.WriteLine($"RA: {RA}");
        Console.WriteLine($"Nome: {Nome}");
        
        Console.Write("Digite a Nota da Prova: ");
        NotaProva = double.Parse(Console.ReadLine());
        
        Console.Write("Digite a Nota do Trabalho: ");
        NotaTrabalho = double.Parse(Console.ReadLine());
    }

    public void CalcularMedia()
    {
        NotaFinal = (NotaProva + NotaTrabalho) / 2;
    }

    public bool CalcularNotaFinal()
    {
        double mediaParaAprovacao = 7.0;
        
        if (NotaFinal >= mediaParaAprovacao)
        {
            Console.WriteLine("Aluno aprovado!");
            return true;
        }
        else
        {
            double notaNecessaria = (mediaParaAprovacao * 2) - NotaFinal;
            Console.WriteLine($"Aluno precisa tirar {notaNecessaria:F2} na prova final para ser aprovado.");
            return false;
        }
    }

    public void ImprimirNotaFinal()
    {
        Console.WriteLine($"Nota Final: {NotaFinal:F2}");
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno();
        aluno.ReceberDados();
        aluno.CalcularMedia();
        aluno.ImprimirNotaFinal();
        aluno.CalcularNotaFinal();
    }
}
