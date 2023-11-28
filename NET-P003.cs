using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Produto> estoque = InicializarEstoque();

        Console.WriteLine("Estoque atual:");
        ImprimirEstoque(estoque);

        AdicionarProduto(estoque, new Produto("P003", "Caneta", 50, 1.5));
        AtualizarQuantidade(estoque, "P001", 20);
        RemoverProduto(estoque, "P002");

        Console.WriteLine("\nEstoque após as operações:");
        ImprimirEstoque(estoque);

        ConsultarProdutosComPrecoSuperiorA(estoque, 2.0);
    }

    static List<Produto> InicializarEstoque()
    {
        return new List<Produto>
        {
            new Produto("P001", "Notebook", 10, 2500.0),
            new Produto("P002", "Smartphone", 15, 1200.0),
            new Produto("P003", "Mouse", 30, 25.0)
        };
    }

    static void ImprimirEstoque(IEnumerable<Produto> estoque)
    {
        foreach (var produto in estoque)
        {
            Console.WriteLine(produto);
        }
    }

    static void AdicionarProduto(List<Produto> estoque, Produto produto)
    {
        estoque.Add(produto);
        Console.WriteLine($"\nProduto '{produto.Nome}' adicionado ao estoque.");
    }

    static void AtualizarQuantidade(List<Produto> estoque, string codigoProduto, int novaQuantidade)
    {
        var produto = estoque.FirstOrDefault(p => p.Codigo == codigoProduto);
        if (produto != null)
        {
            produto.Quantidade = novaQuantidade;
            Console.WriteLine($"\nQuantidade do produto '{produto.Nome}' atualizada para {novaQuantidade}.");
        }
        else
        {
            Console.WriteLine($"\nProduto com código '{codigoProduto}' não encontrado no estoque.");
        }
    }

    static void RemoverProduto(List<Produto> estoque, string codigoProduto)
    {
        var produto = estoque.FirstOrDefault(p => p.Codigo == codigoProduto);
        if (produto != null)
        {
            estoque.Remove(produto);
            Console.WriteLine($"\nProduto '{produto.Nome}' removido do estoque.");
        }
        else
        {
            Console.WriteLine($"\nProduto com código '{codigoProduto}' não encontrado no estoque.");
        }
    }

    static void ConsultarProdutosComPrecoSuperiorA(List<Produto> estoque, double valorLimite)
    {
        var produtosFiltrados = estoque.Where(p => p.Preco > valorLimite);
        Console.WriteLine($"\nProdutos com preço superior a {valorLimite}:");
        ImprimirEstoque(produtosFiltrados);
    }
}

class Produto
{
    public string Codigo { get; }
    public string Nome { get; }
    public int Quantidade { get; set; }
    public double Preco { get; }

    public Produto(string codigo, string nome, int quantidade, double preco)
    {
        Codigo = codigo;
        Nome = nome;
        Quantidade = quantidade;
        Preco = preco;
    }

    public override string ToString()
    {
        return $"Código: {Codigo}, Nome: {Nome}, Quantidade: {Quantidade}, Preço: {Preco}";
    }
}
