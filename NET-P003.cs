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

        Console.Write("\nInforme o código do produto a ser adicionado: ");
        string codigo = Console.ReadLine();
        Console.Write("Informe o nome do produto: ");
        string nome = Console.ReadLine();
        Console.Write("Informe a quantidade do produto: ");
        int quantidade = int.Parse(Console.ReadLine());
        Console.Write("Informe o preço do produto: ");
        double preco = double.Parse(Console.ReadLine());

        AdicionarProduto(estoque, new Produto(codigo, nome, quantidade, preco));

        Console.Write("\nInforme o código do produto a ter a quantidade atualizada: ");
        string codigoAtualizar = Console.ReadLine();
        Console.Write("Informe a nova quantidade do produto: ");
        int novaQuantidade = int.Parse(Console.ReadLine());

        AtualizarQuantidade(estoque, codigoAtualizar, novaQuantidade);

        Console.Write("\nInforme o código do produto a ser removido: ");
        string codigoRemover = Console.ReadLine();
        RemoverProduto(estoque, codigoRemover);

        Console.WriteLine("\nEstoque após as operações:");
        ImprimirEstoque(estoque);

        Console.Write("\nInforme o valor limite para consultar produtos com preço superior a: ");
        double valorLimiteConsulta = double.Parse(Console.ReadLine());
        ConsultarProdutosComPrecoSuperiorA(estoque, valorLimiteConsulta);
    }

    static List<Produto> InicializarEstoque()
    {
        return new List<Produto>();
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
        return $"Código: {Codigo}, Nome: {Nome}, Quantidade: {Quantidade}, Preço: {Preco:C}";
    }
}
