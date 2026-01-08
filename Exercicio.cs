using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        

        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "exemplo");


        string tarefaPath = "tarefas.txt";

        string caminhocompleto = Path.Combine(path, tarefaPath);

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Console.WriteLine("pasta criada com sucesso");
        }
        else
        {
            Console.WriteLine("Ja existe essa pasta meu bom");

        }

        while (true)
        {
            Console.WriteLine("\nFale uma tarefa pra registrar (ou digite 'sair' para encerrar):");
            string? tarefa = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(tarefa))
            {
                Console.WriteLine("Tarefa inválida, tente novamente.");
                continue;
            }

            if (tarefa.Trim().ToLower() == "sair")
            {
                Console.WriteLine("Encerrando o programa.");
                break;
            }   

                string linha = $"[{DateTime.Now:dd/MM/yyyy HH:mm:ss}] {tarefa}";

                try

                {



                    using (StreamWriter sw = File.AppendText(caminhocompleto))
                    {
                        sw.WriteLine(linha);

                    }
                }


                catch (Exception ex)
                {
                    Console.WriteLine($"Deu ruim!!! {ex.Message}");
                    return;
                }

                Console.WriteLine("\nTarefas registradas");

                try

                {
                    string[] todas = File.ReadAllLines(caminhocompleto);
                    foreach (var i in todas)
                    {
                        Console.WriteLine(i);
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Deu ruim de novo!!! {ex.Message}");
                }
            }
        }
    }
   
    

