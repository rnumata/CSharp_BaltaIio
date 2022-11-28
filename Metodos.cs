using System;

static class Metodos
{
  public static string imprimir(string nome, string sobrenome, int idade)
  {
    return ($"O {nome} {sobrenome} tem {idade.ToString()} anos");
  }
}

class MetodosII
{
  /*
  idade pode ser suprimida na chamada. Se vier substiruirá o valor setado no parametro (18). Tem que estar na
  última posiçao dos parametros
  */
  public string imprimir(string nome, string sobrenome, int idade = 18)
  {
    return ($"O {nome} {sobrenome} tem {idade.ToString()} anos");
  }

}