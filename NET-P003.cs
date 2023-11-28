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