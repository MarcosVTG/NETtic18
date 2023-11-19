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
    private static void ExibirMenu()
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Adicionar Tarefa");
        Console.WriteLine("2 - Exibir Tarefas");
        Console.WriteLine("3 - Marcar Tarefa como Concluída");
        Console.WriteLine("4 - Exibir Tarefas Pendentes");
        Console.WriteLine("5 - Exibir Tarefas Concluídas");
        Console.WriteLine("6 - Excluir Tarefa");
        Console.WriteLine("7 - Pesquisar Tarefa por Palavra-Chave");
        Console.WriteLine("8 - Exibir Estatísticas");
        Console.WriteLine("9 - Sair");
    }

    private static void ProcessarOpcao(int opcao)
    {
        switch (opcao)
        {
            case 1:
                AdicionarTarefa();
                break;
            case 2:
                ExibirTarefas();
                break;
            case 3:
                MarcarComoConcluida();
                break;
            case 4:
                ExibirTarefasPendentes();
                break;
            case 5:
                ExibirTarefasConcluidas();
                break;
            case 6:
                ExcluirTarefa();
                break;
            case 7:
                PesquisarTarefasPorPalavraChave();
                break;
            case 8:
                ExibirEstatisticas();
                break;
            case 9:
                Console.WriteLine("Encerrando o Gerenciador de Tarefas. Adeus!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida! Por favor, digite um número válido.");
                break;
        }
    }
private static void ExibirMenu()
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Adicionar Tarefa");
        Console.WriteLine("2 - Exibir Tarefas");
        Console.WriteLine("3 - Marcar Tarefa como Concluída");
        Console.WriteLine("4 - Exibir Tarefas Pendentes");
        Console.WriteLine("5 - Exibir Tarefas Concluídas");
        Console.WriteLine("6 - Excluir Tarefa");
        Console.WriteLine("7 - Pesquisar Tarefa por Palavra-Chave");
        Console.WriteLine("8 - Exibir Estatísticas");
        Console.WriteLine("9 - Sair");
    }

    private static void ProcessarOpcao(int opcao)
    {
        switch (opcao)
        {
            case 1:
                AdicionarTarefa();
                break;
            case 2:
                ExibirTarefas();
                break;
            case 3:
                MarcarComoConcluida();
                break;
            case 4:
                ExibirTarefasPendentes();
                break;
            case 5:
                ExibirTarefasConcluidas();
                break;
            case 6:
                ExcluirTarefa();
                break;
            case 7:
                PesquisarTarefasPorPalavraChave();
                break;
            case 8:
                ExibirEstatisticas();
                break;
            case 9:
                Console.WriteLine("Encerrando o Gerenciador de Tarefas. Adeus!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida! Por favor, digite um número válido.");
                break;
        }
    }

    private static void AdicionarTarefa()
    {
        Console.WriteLine("Digite o título da tarefa:");
        string titulo = Console.ReadLine();

        Console.WriteLine("Digite a descrição da tarefa:");
        string descricao = Console.ReadLine();

        DateTime dataVencimento;
        do
        {
            Console.WriteLine("Digite a data de vencimento da tarefa (dd/MM/aaaa):");
        } while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataVencimento));

        Tarefa novaTarefa = new Tarefa
        {
            Titulo = titulo,
            Descricao = descricao,
            DataVencimento = dataVencimento,
            Concluida = false
        };

        tarefas.Add(novaTarefa);
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

