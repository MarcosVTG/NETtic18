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