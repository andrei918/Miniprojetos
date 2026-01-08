using System;
using System.IO;

class Empregado
{


    public int Idade { get; set; }
    public string? Cargo { get; set; }

    public double Salario { get; set; }
    public string? Nome { get; set; }

    public Empregado(string nome, string cargo, int idade, double salario)
    {

        Nome = nome;
        Cargo = cargo;
        Idade = idade;
        Salario = salario;

    }
    



}
class Program
{
    static void Main(string[] args)
    {
        List<Empregado> funcionario = new List<Empregado>();
        {
            funcionario.Add(new Empregado("cleber", "Executivo", 19, 6.7800));
        }
        while (true)
        {
            Console.WriteLine("\n 1- Cadastrar Funcionario \n 2- Listar os funcionarios cadastrados \n 3- Busque funcionario por Nome \n 4-Calcular media salarial \n 5-Remover funcionario pelo nome \n 6-Sair");
            string? opcao = Console.ReadLine();
            if (opcao == "1")
            {
                Console.WriteLine("Digite o nome do individuo");
                string? indi = Console.ReadLine();


                Console.WriteLine("Digite o cargo do individuo");
                string? carg = Console.ReadLine();

                Console.WriteLine("Digite a idade do individuo");
                string? idad = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(indi) || string.IsNullOrWhiteSpace(carg))
                {
                    Console.WriteLine("Nome e cargo não podem ser vazios.");
                }
                else if (int.TryParse(idad, out int idade))
                {
                    Console.WriteLine("Fale o salario do individuo");
                    string? salar = Console.ReadLine();
                    if (double.TryParse(salar, out double salari))
                    {
                        funcionario.Add(new Empregado(indi, carg, idade, salari));
                        Console.WriteLine("Funcionario cadastrado");

                    }
                    else
                    {
                        Console.WriteLine("Invalido");

                    }
                }
            }
            else if (opcao == "2")
            {
                if (funcionario.Count == 0)
                {
                    Console.WriteLine("tem nada na lista carai");
                    continue;

                }
                else
                {
                    foreach (var funci in funcionario)
                    {
                        Console.WriteLine($"Nome:{funci.Nome}: cargo:{funci.Cargo}: idade:{funci.Idade}: salario:{funci.Salario}");
                    }
                }
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Qual o nome do funcionário");
                string? buscaNomefc = Console.ReadLine();
                var encontrados = funcionario.Where(l => l.Nome!.Equals(buscaNomefc, StringComparison.OrdinalIgnoreCase));

                if (!encontrados.Any())
                {
                    Console.WriteLine("Ninguem com este nome nââ");

                }
                else
                {
                    foreach (var Empregado in encontrados)

                    {
                        Console.WriteLine($"Nome:{Empregado.Nome}, Salario:{Empregado.Salario}, cargo:{Empregado.Cargo}, Idade:{Empregado.Idade}");


                    }
                }
            }
            else if (opcao == "4")
            {
                double media = funcionario.Average(f => f.Salario);

                Console.WriteLine($"A media salarial dos funcionario {media}");

            }


            else if (opcao == "5")
            {
                Console.WriteLine("Fale o nome do funcionario pra ser removido");
                string? removerNomefc = Console.ReadLine();
                var Removido = funcionario.RemoveAll(l => l.Nome!.Equals(removerNomefc, StringComparison.OrdinalIgnoreCase));
                if (Removido > 0)
                {
                    Console.WriteLine($"{Removido} funcionario removido.");


                }

                else if (funcionario.Count == 0)
                {
                    Console.WriteLine("Tem ninguem na lista");


                }
                else
                {
                    Console.WriteLine("erro");
                    continue;

                }
            }

            else if (opcao == "6")
            {
                Console.WriteLine("Saindoo..");
                break;



            }
            else
            {
                Console.WriteLine("opção invalida");

            }
                

            }






                }



                }



                
            
        

    

