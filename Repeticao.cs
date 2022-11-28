using System;

class Repeticao
{
  // for
  public void RepeticaoFor()
  {
    for (int i = 0; i <= 5; i++)
    {
      Console.WriteLine(i);
    }
  }

  //while .... ctrl c para sair do loop infinito
  public void RepeticaoWhile()
  {
    int valor = 0;
    while (valor <= 5)
    {
      Console.WriteLine(valor);
      valor++;
    }
  }

  //do while
  public void RepeticaoDoWhile()
  {
    int v = 0;
    do
    {
      Console.WriteLine(v);
      v++;
    } while (v < 6);
  }
}