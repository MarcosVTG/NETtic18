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
