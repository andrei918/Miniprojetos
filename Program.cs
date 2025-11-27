using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Net.Mail;
using System.Globalization;

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
                    Console.WriteLine("Data inválida:");
                    continue;

                }


                if (!string.IsNullOrWhiteSpace(descricao))
                {
                    tarefas.Add(descricao);
                    prazos[descricao] = prazo;
                    Console.WriteLine("Tarefa  adicionada com sucesso!");
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

            else
            {
                Console.WriteLine("Opção inválida. Tente novamente. ");

            }
            }

                    
            }
            }
       
    
