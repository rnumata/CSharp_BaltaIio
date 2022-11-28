using System;
using System.IO;

static class TextEditor
{

  public static void Editar()
  {
    Console.Clear();
    Console.WriteLine("Digite seu texto (ESC para sair)");
    Console.WriteLine("--------------------");

    string text = "";

    do
    {
      text += Console.ReadLine();
      text += Environment.NewLine;  //quebra linha
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Salvar(text);
  }

  public static void Abrir()
  {
    Console.Clear();
    Console.WriteLine("Qual diretório a salvar?");
    var path = "/Users/regisnumata/Desktop/teste.rtf";

    using (var file = new StreamReader(path))
    {
      string text = file.ReadToEnd();
      Console.WriteLine(text);
    }
    Console.ReadKey();
  }

  public static void Salvar(string text)
  {
    Console.Clear();
    Console.WriteLine(" Qual diretório a salvar?");
    var path = Console.ReadLine();

    //tudo que passar para o using ele vai abrir e fechar
    using (var file = new StreamWriter(path))
    {
      file.Write(text);
    }
    Console.WriteLine("Arquivo salvo com sucesso");

  }

}