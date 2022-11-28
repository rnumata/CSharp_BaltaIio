using System;

namespace CSharp_BaltaIio
{
  class Reais
  {
    public float num_float { get; set; }    // float num_float = 2.50f;
    public double num_double { get; set; }  // double num_double = 22.000;
    public decimal num_decimal { get; set; }// decimal num_decimal = 2.400M;

    public Reais(float f, double d, decimal de)
    {
      num_float = f;
      num_double = d;
      num_decimal = de;
    }

    public void mostrarNumeros()
    {
      Console.WriteLine($"float: {this.num_float} - double: {this.num_double} - decimal: {this.num_decimal}");
    }
  }
}
