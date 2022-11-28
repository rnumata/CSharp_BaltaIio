using System;
using System.Collections.Generic;

namespace CSharp_BaltaIio
{

  public static class Arrays
  {

    public static void ObterArrays()
    {

      Console.Clear();

      //Tipos de Lista
      var meuArray = new int[5];   //inicializando com 5 posiçoes
      int[] meuArrayII = new int[5] { 0, 1, 2, 3, 4 };  //inicializando com valores

      foreach (var item in meuArrayII)
      {
        Console.WriteLine(item);
      }


      List<int> lista = new List<int>();
      for (int i = 1; i < 10; i++)
      {
        lista.Add(i);
      }

      foreach (var item in lista)
      {
        Console.WriteLine($"Item: {item}");
      }

    }
  }
}