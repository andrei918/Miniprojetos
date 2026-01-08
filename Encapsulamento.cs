using System.Security.Cryptography.X509Certificates;
using System;
// Exemplo de encapsulamento em C#
// A classe Produto tem propriedades privadas e públicas para controlar o acesso aos dados

class Produto
{
    public string? Nome { get; set; }

    private double preco;
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value >= 0)
                preco = value;
            else
                Console.WriteLine("Preço invalido.");


        }
    }


    private int quantidade;

    public int Quantidade
    {

        get { return quantidade; }
        set
        {
            if (value >= 0)
                quantidade = value;
            else
                Console.WriteLine("Quantidade invalida.");

        }

    }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;

    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Produto: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}");



    }
}
class Program
{


    static void Main(string[] args)

    {
        Produto p1 = new Produto("Mouse", 80.50, 40);
        p1.ExibirInfo();
      


    }
} 
  









