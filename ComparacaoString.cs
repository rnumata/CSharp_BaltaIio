using System;
using System.Text;

static class ComparacaoString
{

  public static void Comparar()
  {
    var numero = 10;
    var texto = "Testando";

    Console.WriteLine(texto.CompareTo("Testando"));  // retonrno 0
    Console.WriteLine(texto.CompareTo("testando"));  // retorno 1

    Console.WriteLine(texto.Contains("est"));    // retorno true
    Console.WriteLine(texto.Contains("EST", StringComparison.OrdinalIgnoreCase));  // ignora o case sensitive

    Console.WriteLine(texto.StartsWith("Test"));  // retorno true
    Console.WriteLine(texto.StartsWith("test"));  // retorno false
    Console.WriteLine(texto.StartsWith("test", StringComparison.OrdinalIgnoreCase));  // retorno true

    Console.WriteLine(texto.EndsWith("ando"));  // retorno true

    Console.WriteLine(texto.Equals("Testando")); // compara se um Obj é igual a outro

    Console.WriteLine(numero.Equals(10));  // true

    Console.WriteLine(texto.IndexOf("e"));  // 1

    Console.WriteLine(texto.ToUpper());  //TESTANDO

    Console.WriteLine(texto.Insert(2, "S"));  //insere o S na posicao 2 TeSstando

    Console.WriteLine(texto.Remove(2, 3));  // tendo

    Console.WriteLine(texto.Replace("Test", "Cod"));  // De Testando para Codando

    var textoDividido = texto.Split("n");
    Console.WriteLine(textoDividido[0] + " " + textoDividido[1]);  //Testa do

    var resultado = texto.Substring(0, 2);  // a partir do 0 pega 2 chars
    Console.WriteLine(resultado);

    var novoTexto = " Tira o espaço no início e no fim ";
    Console.WriteLine(novoTexto.Trim());

    var textoStringBuider = new StringBuilder();
    textoStringBuider.Append("texto primeiro paragrafo. ");
    textoStringBuider.Append(" texto segundo paragrafo. ");
    textoStringBuider.Append(" texto terceiro paragrafo. ");
    textoStringBuider.ToString();
    Console.WriteLine(textoStringBuider);

  }



}