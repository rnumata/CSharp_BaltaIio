using System;
using System.Threading;
static class Start
{

  public static void Cronometrar(int time)
  {

    int currentTime = 0;
    while (currentTime != time)
    {
      Console.Clear();
      currentTime++;
      Console.WriteLine(currentTime);
      Thread.Sleep(1000);
    }

  }


}