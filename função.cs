using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;









 class Produto
{
    
    public string? Nome { get; set; }
    public string? Categoria { get; set; }
    public double Preco { get; set; }




}
class Program
{

    static void Main(string[] args)
    
    {




        List<double> precos = new List<double>() { 1250.90, 3563.90, 3620.90, 1200.00, 530.00, 123.00 };

        var precoOrdenado = precos.OrderBy(p => p);

        System.Console.WriteLine("Preços do mais barato do mais caro");

        foreach (var p in precoOrdenado)

        {

            System.Console.WriteLine($"R${p}");
        }

        List<Produto> produtos = new List<Produto>();
        {

         produtos.Add(new Produto() { Nome = "Celular", Preco = 1250.90, Categoria = "Eletronicos" });
         produtos.Add(new Produto() { Nome = "Computador", Preco = 3563.90, Categoria = "Eletronicos" });
         produtos.Add(new Produto() { Nome = "Console", Preco = 3620.900, Categoria = "Eletronicos" });
        }
        var eletronicosOrdenados = produtos.
        Where(p => p.Categoria == "Eletronicos").OrderBy(p => p.Preco);
        Console.WriteLine("");
        Console.WriteLine("Todos produtos eletrônicos");

        foreach (var p in eletronicosOrdenados)
        {
            Console.WriteLine($"{p.Nome} - {p.Categoria} - R${p.Preco}");
        }
    }
    

}
