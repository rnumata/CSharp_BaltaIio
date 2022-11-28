using System;
using System.Globalization;

namespace CSharp_BaltaIio
{

  public static class Moeda
  {

    public static void gerarMoeda()
    {
      Console.Clear();

      var culture = CultureInfo.CreateSpecificCulture("pt-BR");

      decimal valor = 10.50m;   //decimal - Recomendacao para moeda

      Console.WriteLine(valor.ToString("C", culture));  // R$ 10,50  C de currency
      Console.WriteLine(valor.ToString("N", culture));  // 10,500
      Console.WriteLine(valor.ToString("P", culture));  // 1.050,000%

      Console.WriteLine(Math.Round(valor));   // 10
      Console.WriteLine(Math.Ceiling(valor));  //11
      Console.WriteLine(Math.Floor(valor));    //10

    }


  }

}