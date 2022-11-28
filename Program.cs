using System;

namespace CSharp_BaltaIio
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      Conversao c = new Conversao();
      c.conversaoImplicita();
      c.conversaoexplicita();
      c.conversaoParse();
      c.conversaoConvert();
      */

      /*
      Repeticao r = new Repeticao();
      r.RepeticaoFor();
      r.RepeticaoWhile();
      r.RepeticaoDoWhile();
      */

      /*
      //com classe e metodos static
      Console.WriteLine(Metodos.imprimir("Titi", "Suezo", 17));
      //com classe instanciada
      MetodosII m = new MetodosII();
      Console.WriteLine(m.imprimir("Tiago", "Numata", 20));
      */

      /*
      Product p = new Product(1, "Video Game", 10.5, EEmbalagem.Palete);
      Console.WriteLine(p.PriceInDolar(2));
      Console.WriteLine(p.Embalagem);
      Console.WriteLine((int)p.Embalagem);
      */

      //-----------Calculator----------------
      //MenuCalculator();

      //-----------stopWatch-----------------
      //MenuStopwatch();

      //-----------TextEditor----------------
      //MenuTextEditor();

      //------------GerarGuid---------------
      //GerarGuid.Gerarguid();

      //-----------Comparacao de string ------
      //ComparacaoString.Comparar();

      //-----------DateTime------------------
      //Data.GerarData();

      //-----------Moeda--------------------
      //Moeda.gerarMoeda();

      //-----------Arrays--------------------
      //Arrays.ObterArrays();

      //-----------Exception-----------------
      //Excecao.ExemploI();
      //Excecao.ExemploII();
      //Excecao.ExemploIII();

    }

    static void MenuCalculator()
    {
      Console.Clear();
      Console.WriteLine("Selecione a opção: ");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("0 - Sair");
      Console.WriteLine("----------------------");

      int opcao = int.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 1:
          Calculator.Soma();
          MenuCalculator();
          break;
        case 2:
          Calculator.Subtracao();
          MenuCalculator();
          break;
        case 3:
          Calculator.Divisao();
          MenuCalculator();
          break;
        case 4:
          Calculator.Multiplicacao();
          MenuCalculator();
          break;
        case 0:
          System.Environment.Exit(0);
          break;
        default:
          MenuCalculator();
          break;
      }
    }

    static void MenuStopwatch()
    {
      Console.Clear();
      Console.Write("Infome tempo em segundos? pex 5s ou ");
      Console.WriteLine("Infome tempo em minnutos? pex 2M");
      string tempo = Console.ReadLine().ToLower();
      char type = char.Parse(tempo.Substring(tempo.Length - 1, 1));  //substring(x,y) onde x é a posição e y quantos chars
      int time = int.Parse(tempo.Substring(0, tempo.Length - 1));

      if (type.Equals('s')) Start.Cronometrar(time);
      if (type.Equals('m')) Start.Cronometrar(time * 60);
    }

    static void MenuTextEditor()
    {
      Console.Clear();
      Console.WriteLine("1 - Abrir arquivo");
      Console.WriteLine("2 - Criar Texto");
      Console.WriteLine("0 - Sair");
      short opcao = short.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 1: TextEditor.Abrir(); MenuTextEditor(); break;
        case 2: TextEditor.Editar(); break;
        case 0: System.Environment.Exit(0); break;
        default: MenuTextEditor(); break;
      }

    }

  }
}
