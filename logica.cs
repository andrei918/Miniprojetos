using System;
using System.Collections.Generic;
using System.Net;


class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }


        Console.WriteLine("Escolha um numero aleatorio entre 1 e 10:");
        string? opcao = Console.ReadLine();
        if (opcao != null && numeros.Contains(int.Parse(opcao)))
        {
            Console.WriteLine("Numero valido!");
        }
        else
        {
            Console.WriteLine("Numero invalido!");
            return;
        }
        if (opcao != null && int.TryParse(opcao, out int numeroEscolhido) && new[] { 1, 3, 5, 7, 9 }.Contains(numeroEscolhido))
        {
            Console.WriteLine("Você escolheu um número ímpar!");
        }
        else
        {
            Console.WriteLine("Você escolheu um número par!");
        }
    }
}  