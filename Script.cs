using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;


class Program

{
    static void Main(string[] args)
    {
        string pastalegal = @"C:\Users\andrei\Documents\lapeterrie";

        var tipos = new Dictionary<string, string[]>
        {
            { "Imagens", new[] {".jpeg", ".png"} },
            {"Videos", new [] {".mp4"} },
            {"Documentos", new[] {".pdf", ".txt"} }
        };

        foreach (var tipo in tipos.Keys)
        {
            string caminho = Path.Combine(pastalegal, tipo);
            if (!Directory.Exists(caminho))
                Directory.CreateDirectory(caminho);
        }

        var arquivos = Directory.GetFiles(pastalegal);
        foreach (var arquivo in arquivos)
        {
            string extensao = Path.GetExtension(arquivo).ToLower();
           
            foreach (var tipo in tipos)
            {
                
            
            if (Array.Exists(tipo.Value, ext => ext == extensao))
            {
                string destino = Path.Combine(pastalegal, tipo.Key, Path.GetFileName(arquivo));
                File.Move(arquivo, destino);
               
                break;

                
            }
            }
        }
        Console.WriteLine("Concluido");

    }
  
}