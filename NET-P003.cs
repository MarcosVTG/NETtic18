using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<(string Codigo, string Nome, int Quantidade, double Preco)> estoque = InicializarEstoque();

        Console.WriteLine("Estoque atual:");
        ImprimirEstoque(estoque);

        AdicionarProduto(estoque, ("P003", "Caneta", 50, 1.5));
        AtualizarQuantidade(estoque, "P001", 20);
        RemoverProduto(estoque, "P002");

        Console.WriteLine("\nEstoque após as operações:");
        ImprimirEstoque(estoque);

        ConsultarProdutosComPrecoSuperiorA(estoque, 2.0);
    }
static List<(string Codigo, string Nome, int Quantidade, double Preco)> InicializarEstoque()
    {
        return new List<(string, string, int, double)>
        {
            ("P001", "Notebook", 10, 2500.0),
            ("P002", "Smartphone", 15, 1200.0),
            ("P003", "Mouse", 30, 25.0)
        };
    }
    static void ImprimirEstoque(List<(string Codigo, string Nome, int Quantidade, double Preco)> estoque)
    {
        foreach (var produto in estoque)
        {
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
        }
    }

    static void AdicionarProduto(List<(string Codigo, string Nome, int Quantidade, double Preco)> estoque, (string, string, int, double) dadosProduto)
    {
        estoque.Add(dadosProduto);
        Console.WriteLine($"\nProduto '{dadosProduto.Nome}' adicionado ao estoque.");
    }

    static void AtualizarQuantidade(List<(string Codigo, string Nome, int Quantidade, double Preco)> estoque, string codigoProduto, int novaQuantidade)
    {
        var produto = estoque.FindIndex(p => p.Codigo == codigoProduto);
        if (produto != -1)
        {
            var produtoAtualizado = estoque[produto];
            produtoAtualizado.Quantidade = novaQuantidade;
            estoque[produto] = produtoAtualizado;
            Console.WriteLine($"\nQuantidade do produto '{produtoAtualizado.Nome}' atualizada para {novaQuantidade}.");
        }
        else
        {
            Console.WriteLine($"\nProduto com código '{codigoProduto}' não encontrado no estoque.");
        }
    }

    static void RemoverProduto(List<(string Codigo, string Nome, int Quantidade, double Preco)> estoque, string codigoProduto)
    {
        var produto = estoque.FindIndex(p => p.Codigo == codigoProduto);
        if (produto != -1)
        {
            var produtoRemovido = estoque[produto];
            estoque.RemoveAt(produto);
            Console.WriteLine($"\nProduto '{produtoRemovido.Nome}' removido do estoque.");
        }
        else
        {
            Console.WriteLine($"\nProduto com código '{codigoProduto}' não encontrado no estoque.");
        }
    }

    static void ConsultarProdutosComPrecoSuperiorA(List<(string Codigo, string Nome, int Quantidade, double Preco)> estoque, double valorLimite)
    {
        var produtosFiltrados = estoque.Where(p => p.Preco > valorLimite);
        Console.WriteLine($"\nProdutos com preço superior a {valorLimite}:");
        ImprimirEstoque(produtosFiltrados.ToList());
    }
}
static (string Codigo, string Nome, int Quantidade, double Preco) BuscarProdutoPorCodigo(List<(string Codigo, string Nome, int Quantidade, double Preco)> estoque, string codigoDesejado)
    {
        var produto = estoque.FirstOrDefault(p => p.Codigo == codigoDesejado);
        if (produto != default)
        {
            return produto;
        }
        else
        {
            throw new ProdutoNaoEncontradoException($"Produto com código '{codigoDesejado}' não encontrado.");
        }
    }
}

class ProdutoNaoEncontradoException : Exception
{
    public ProdutoNaoEncontradoException(string message) : base(message)
    {
    }
}
class Program
{
    static void Main()
    {
        List<(string Codigo, string Nome, int Quantidade, double Preco)> estoque = InicializarEstoque();

        Console.WriteLine("Estoque atual:");
        ImprimirEstoque(estoque);

        Console.Write("\nInforme o limite de quantidade em estoque para o Relatório 1: ");
        int limiteQuantidade1 = int.Parse(Console.ReadLine());
        var relatorio1 = GerarRelatorioQuantidadeAbaixoLimite(estoque, limiteQuantidade1);
        Console.WriteLine($"\nRelatório 1: Produtos com quantidade abaixo de {limiteQuantidade1}");
        ImprimirEstoque(relatorio1.ToList());

        Console.Write("\nInforme o valor mínimo para o Relatório 2: ");
        double valorMinimo2 = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor máximo para o Relatório 2: ");
        double valorMaximo2 = double.Parse(Console.ReadLine());
        var relatorio2 = GerarRelatorioValorEntreMinimoMaximo(estoque, valorMinimo2, valorMaximo2);
        Console.WriteLine($"\nRelatório 2: Produtos com valor entre {valorMinimo2} e {valorMaximo2}");
        ImprimirEstoque(relatorio2.ToList());

        var relatorio3 = GerarRelatorioValorTotalEstoque(estoque);
        Console.WriteLine("\nRelatório 3: Valor total do estoque e valor total de cada produto");
        Console.WriteLine($"Valor total do estoque: {relatorio3.ValorTotalEstoque}");
        foreach (var produto in relatorio3.ValorTotalPorProduto)
        {
            Console.WriteLine($"Produto: {produto.Nome}, Valor total: {produto.ValorTotal}");
        }
    }

    static List<(string Codigo, string Nome, int Quantidade, double Preco)> InicializarEstoque()
    {
        return new List<(string, string, int, double)>
        {
            ("P001", "Notebook", 10, 2500.0),
            ("P002", "Smartphone", 15, 1200.0),
            ("P003", "Mouse", 30, 25.0)
        };
    }

    static void ImprimirEstoque(IEnumerable<(string Codigo, string Nome, int Quantidade, double Preco)> estoque)
    {
        foreach (var produto in estoque)
        {
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
        }
    }

    static IEnumerable<(string Codigo, string Nome, int Quantidade, double Preco)> GerarRelatorioQuantidadeAbaixoLimite(IEnumerable<(string Codigo, string Nome, int Quantidade, double Preco)> estoque, int limite)
    {
        return estoque.Where(p => p.Quantidade < limite);
    }

    static IEnumerable<(string Codigo, string Nome, int Quantidade, double Preco)> GerarRelatorioValorEntreMinimoMaximo(IEnumerable<(string Codigo, string Nome, int Quantidade, double Preco)> estoque, double minimo, double maximo)
    {
        return estoque.Where(p => p.Preco >= minimo && p.Preco <= maximo);
    }

    static (double ValorTotalEstoque, IEnumerable<(string Nome, double ValorTotal)> ValorTotalPorProduto) GerarRelatorioValorTotalEstoque(IEnumerable<(string Codigo, string Nome, int Quantidade, double Preco)> estoque)
    {
        double valorTotalEstoque = estoque.Sum(p => p.Preco * p.Quantidade);
        var valorTotalPorProduto = estoque.Select(p => (p.Nome, p.Preco * p.Quantidade));
        return (valorTotalEstoque, valorTotalPorProduto);
    }
}