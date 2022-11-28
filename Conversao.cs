using System;

class Conversao
{
  public void conversaoImplicita()
  {
    float valorFloat = 20.5f;
    int valorInt = 10;
    valorFloat = valorInt;
    Console.WriteLine($"Conversão implícita de int para float => {valorFloat}");
  }
  public void conversaoexplicita()
  {
    var valorConvertido = (int)(32.4);
    Console.WriteLine($"Conversao Explícita de float para int => {valorConvertido}");
  }
  public void conversaoParse()
  {
    int i = int.Parse("100"); //sempre espera uma string
    Console.WriteLine($"Conversão com Parse => {i}");
  }
  public void conversaoConvert()
  {
    bool i = Convert.ToBoolean(0);
    Console.WriteLine($"Conversão com Convert de int = 0 para bool => {i}");
  }

}