using System;
using System.Threading.Tasks;


class Program
{




    static double saldo = 1000.0;
    static void Main(string[] args)
    {
        Console.WriteLine("Qual o seu nome?");

        string? nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}");

        bool continuar = true;
        while (continuar)
    { 

            Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Ver Saldo");
        Console.WriteLine("2. Depositar");
        Console.WriteLine("3. Sacar");
        Console.WriteLine("4. Sair");
            Console.Write("escolhe:");
       

        string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    VerSaldo();
                    break;

                case "2":
                    Depositar();
                    break;

                case "3":
                    Sacar();
                    break;

                case "4":
                    Console.WriteLine("Saindo...");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("invalidooooo");
                    break;

            }

        }


        static void VerSaldo()

        {
            Console.WriteLine($"Seu saldo é esse: R$ {saldo}");

        }

        static void Depositar()
        {
            Console.WriteLine("Quanto você desejaria depositar?");
            if (double.TryParse(Console.ReadLine(), out double valor) && valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Deposito seu saldo é  R$ {saldo}");
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
            }
        }

        static void Sacar()
        {
            Console.WriteLine("Quanto você desejaria sacar?");
            if (double.TryParse(Console.ReadLine(), out double valor) && valor > 0)
            {
                if (valor <= saldo)
                {
                    saldo -= valor;
                    Console.WriteLine($"Saque realizado com sucesso! Seu saldo agora é R$ {saldo}");
                }
                else
                {
                    Console.WriteLine("saldo insuficiente. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
            }
        }
    }
}