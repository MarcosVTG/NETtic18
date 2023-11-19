using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Tarefa
{
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime DataVencimento { get; set; }
    public bool Concluida { get; set; }
}

class GerenciadorTarefas
{
    private static List<Tarefa> tarefas = new List<Tarefa>();

    static void Main(string[] args)
    {
        bool emExecucao = true;
        while (emExecucao)
        {
            ExibirMenu();
            if (int.TryParse(Console.ReadLine(), out int opcao))
            {
                ProcessarOpcao(opcao);
            }
            else
            {
                Console.WriteLine("Opção inválida! Por favor, digite um número válido.");
            }
        }
    }

}
