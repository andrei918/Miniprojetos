using System;

interface IAnimal
{
    void Comer();
}

abstract class Animal
{
    public string? Nome { get; set; }

    public void nome()
    {
        Console.WriteLine($"Nome: {Nome}");
    }
    public abstract void Falar();

    public void ExibirInfo()
    {
        Console.Write($"O {Nome} fala:");
        Falar();
    }
}

class Cachorro : Animal, IAnimal
{
    public override void Falar()
    {
        Console.WriteLine(" Au Au!");


    }
    public void Comer()
    {
        Console.WriteLine($"O {Nome} está comendo ração.");


    }
     


    
}




class Gato : Animal, IAnimal
{
    public override void Falar()
    {
        Console.WriteLine(" Miau");

    }

    public void Comer()
    {
        Console.WriteLine($"O {Nome} está comendo ração.");
    }
    public string? Raca { get; set; }
}



class Program
{
    static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro();
        cachorro.Nome = "cachorro thomas";
        cachorro.nome();

        cachorro.ExibirInfo();
        cachorro.Comer();

        Console.WriteLine();

        Gato gato = new Gato();
        gato.Nome = "gato thomas";
        gato.nome();
        gato.ExibirInfo();
        gato.Comer();
    }

}