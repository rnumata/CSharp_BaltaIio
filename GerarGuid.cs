using System;

static class GerarGuid
{
  public static void Gerarguid()
  {
    //Gera um Guid
    var newGuid = Guid.NewGuid();
    Console.WriteLine(newGuid);

    //Atribui um Guid
    newGuid = new Guid("8a1962e8-d6be-4dce-91cd-9d4b0eeccf28");
    Console.WriteLine(newGuid);

    //Possível comparar
    if (newGuid != Guid.NewGuid()) Console.WriteLine("Guids diferentes !");

  }

}
