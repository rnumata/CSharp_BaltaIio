using System;

static class Calculator
{
  //Soma
  public static void Soma()
  {
    Console.Clear();
    Console.WriteLine("1o Valor : ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("2o Valor : ");
    float v2 = float.Parse(Console.ReadLine());

    float soma = v1 + v2;

    Console.WriteLine();
    Console.WriteLine($"A soma de {v1} + {v2} é {soma}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
  }

  public static void Subtracao()
  {
    Console.Clear();
    Console.WriteLine("Informe o 1o valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Informe o 2o valor");
    float v2 = float.Parse(Console.ReadLine());

    float subtracao = v1 - v2;

    Console.WriteLine($"A subtração entre {v1} e {v2} é {subtracao}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
  }

  public static void Divisao()
  {
    Console.Clear();
    Console.WriteLine("Informe o 1o valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Informe o 2o valor");
    float v2 = float.Parse(Console.ReadLine());

    float divisao = v1 / v2;

    Console.WriteLine($"A divisão entre {v1} e {v2} é {divisao}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
  }

  public static void Multiplicacao()
  {
    Console.Clear();
    Console.WriteLine("Informe o 1o valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Informe o 2o valor");
    float v2 = float.Parse(Console.ReadLine());

    float multiplicacao = v1 * v2;

    Console.WriteLine($"O produto entre {v1} e {v2} é {multiplicacao}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
  }





}