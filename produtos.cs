using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; private set; }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            Quantidade += quantidade;
            Console.WriteLine($"{quantidade} unidades adicionadas ao estoque.");
        }
        else
        {
            Console.WriteLine("A quantidade deve ser maior que zero.");
        }
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > 0 && Quantidade >= quantidade)
        {
            Quantidade -= quantidade;
            Console.WriteLine($"{quantidade} unidades removidas do estoque.");
        }
        else if (quantidade > 0)
        {
            Console.WriteLine("Quantidade insuficiente em estoque.");
        }
        else
        {
            Console.WriteLine("A quantidade deve ser maior que zero.");
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}\nPreço: R${Preco:F2}\nQuantidade em estoque: {Quantidade}");
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto("Notebook", 3500.0, 10);
        
        produto.ExibirDetalhes();
        produto.AdicionarEstoque(5);
        produto.ExibirDetalhes();
        produto.RemoverEstoque(3);
        produto.ExibirDetalhes();
    }
}
