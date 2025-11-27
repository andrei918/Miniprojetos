using System;
using System.Globalization;
using System.Threading;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        string documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string caminho = Path.Combine(documentos, "treino");
        Directory.CreateDirectory(caminho);
        for (int i = 68; i <= 70; i++)
       {
           string Subpasta = Path.Combine(caminho, $"treino{i}");
           Directory.CreateDirectory(Subpasta);
       }
   }
}