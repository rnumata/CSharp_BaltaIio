using System;

namespace CSharp_BaltaIio
{
  public static class Excecao
  {

    public static void ExemploI()
    {
      Console.Clear();

      //--------- Exemplo 1
      var arr = new int[3];
      try
      {
        for (int i = 0; i < 5; i++)
        {
          Console.WriteLine(arr[i]);   //erro: System.IndexOutOfRangeException
        }
      }
      catch (IndexOutOfRangeException e)
      {
        Console.WriteLine($"error => {e}");
        Console.WriteLine(e.Message);
      }
      catch (ArgumentNullException e)
      {
        Console.WriteLine($"Outro tipo de exception => {e}");
      }
      catch (System.Exception e)
      {
        Console.WriteLine(e);                 //System.IndexOutOfRangeException: Index was outside the bounds of the array.
        Console.WriteLine(e.Message);         //Index was outside the bounds of the array.
        Console.WriteLine(e.Message.Contains("bounds"));  //true
        Console.WriteLine(e.Source);            //CSharp_BaltaIio
      }
      finally
      {
        //acontece sempre.. mesmo que nao declarado
        Console.WriteLine(".....Fechando o BD.....");
      }

    }

    //--------Exemplo 2
    public static void ExemploII()
    {
      Console.Clear();

      var arr = new int[3];
      try
      {
        for (int i = 0; i < 5; i++)
        {
          Console.WriteLine(arr[i]);
        }
      }
      catch (System.Exception e)
      {
        throw new Exception($"Este é um erro customizado => {e.Message}");
      }
    }

    //--------Exemplo 3
    public static void ExemploIII()
    {
      Console.Clear();
      try
      {
        Salvar("");
      }
      catch (System.Exception e)
      {
        Console.Write(e);
      }
    }

    public static void Salvar(string t)
    {
      if (string.IsNullOrEmpty(t)) throw new ArgumentNullException("Este é um erro customizado");  //entra aqui
    }

  }
}