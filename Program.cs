using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq; // IMPORTANTE para usar LINQ

class Program
{
    static void Main(string[] args)
    {
        List<string> tarefas = new List<string>();
        Dictionary<string, DateTime> prazos = new Dictionary<string, DateTime>();

        while (true)
        {
            Console.WriteLine("\n1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Remover tarefa");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("5 - Listar tarefas que vencem hoje");
            Console.WriteLine("6 - Listar tarefas atrasadas");
            Console.WriteLine("7 - Listar tarefas ordenadas por prazo");
            Console.WriteLine("8 - Listar tarefas ordenadas por nome");
            Console.Write("Escolha uma opção: ");
            string? opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.Write("Digite a descrição da tarefa: ");
                string? descricao = Console.ReadLine();

                Console.Write("Digite o prazo da tarefa (dd/mm/yyyy): ");
                DateTime prazo;

                if (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out prazo))
                {
                    Console.WriteLine("Data inválida.");
                    continue;
                }

                if (!string.IsNullOrWhiteSpace(descricao))
                {
                    tarefas.Add(descricao);
                    prazos[descricao] = prazo;
                    Console.WriteLine("Tarefa adicionada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Descrição da tarefa não pode ser vazia.");
                }
            }

            else if (opcao == "2")
            {
                if (tarefas.Count == 0)
                {
                    Console.WriteLine("Nenhuma tarefa cadastrada.");
                }
                else
                {
                    Console.WriteLine("\nTarefas cadastradas:");
                    foreach (var tarefa in tarefas)
                    {
                        Console.WriteLine($"- {tarefa} (prazo: {prazos[tarefa]:dd/MM/yyyy})");
                    }
                }
            }

            else if (opcao == "3")
            {
                Console.Write("Digite a descrição da tarefa a ser removida: ");
                string? descRemover = Console.ReadLine();
                if (!string.IsNullOrEmpty(descRemover) && tarefas.Remove(descRemover))
                {
                    prazos.Remove(descRemover);
                    Console.WriteLine("Tarefa removida com sucesso!");
                }
                else
                {
                    Console.WriteLine("Tarefa não encontrada.");
                }
            }

            else if (opcao == "4")
            {
                Console.WriteLine("Saindooooooo");
                break;
            }

            else if (opcao == "5")
            {
                var tarefasHoje = tarefas.Where(t => prazos[t].Date == DateTime.Today);
                Console.WriteLine("\nTarefas que vencem hoje:");
                foreach (var tarefa in tarefasHoje)
                {
                    Console.WriteLine($"- {tarefa} (prazo: {prazos[tarefa]:dd/MM/yyyy})");
                }
            }

            else if (opcao == "6")
            {
                var atrasadas = tarefas.Where(t => prazos[t].Date < DateTime.Today);
                Console.WriteLine("\nTarefas atrasadas:");
                foreach (var tarefa in atrasadas)
                {
                    int diasAtraso = (DateTime.Today - prazos[tarefa]).Days;
                    Console.WriteLine($"- {tarefa} ({diasAtraso} dias atrasada)");
                }
            }

            else if (opcao == "7")
            {
                var ordenadasPorPrazo = tarefas.OrderBy(t => prazos[t]);
                Console.WriteLine("\nTarefas ordenadas por prazo:");
                foreach (var tarefa in ordenadasPorPrazo)
                {
                    Console.WriteLine($"- {tarefa} (prazo: {prazos[tarefa]:dd/MM/yyyy})");
                }
            }

            else if (opcao == "8")
            {
                var ordenadasPorNome = tarefas.OrderBy(t => t);
                Console.WriteLine("\nTarefas ordenadas por nome:");
                foreach (var tarefa in ordenadasPorNome)
                {
                    Console.WriteLine($"- {tarefa} (prazo: {prazos[tarefa]:dd/MM/yyyy})");
                }
            }

            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }
}
