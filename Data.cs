using System;
using System.Globalization;

namespace CSharp_BaltaIio
{

  public static class Data
  {
    public static void GerarData()
    {
      Console.Clear();

      var dataAgora = DateTime.Now;
      Console.WriteLine($"Data atual: {dataAgora}");
      Console.WriteLine($"Dia do Ano atual: {dataAgora.DayOfYear}");
      Console.WriteLine($"Dia da semana: {dataAgora.DayOfWeek}");  //ex: Thursday
      Console.WriteLine($"Numero do Dia da semana: {(int)dataAgora.DayOfWeek}"); //ex: 4

      var dataFormatadaAno = String.Format("{0:dd/MM/yyyy}", dataAgora);  //ex 19/11/2022
      Console.WriteLine(dataFormatadaAno);

      var dataFormatadaHora = String.Format("{0:dd/MM/yyyy HH:mm:ss z}", dataAgora);  //ex 19/11/2022 20:08:30 -3
      Console.WriteLine(dataFormatadaHora);

      var dataFormatadaLong = string.Format("{0:T}", dataAgora);  //ex 8:16:35 PM  ou  08:16 PM com t
      Console.WriteLine(dataFormatadaLong);

      var dataFormatadaDay = string.Format("{0:D}", dataAgora);  //ex saturday, November 19, 2022  
      Console.WriteLine(dataFormatadaDay);

      var dataFormatadaDia = string.Format("{0:d}", dataAgora);  //ex 11/19/2022 8:21 PM   (r, s , u)
      Console.WriteLine(dataFormatadaDia);
      Console.WriteLine(dataAgora.ToString("d"));

      Console.WriteLine(dataAgora.AddDays(5));  // adiciona x dias  e -5 retira
      Console.WriteLine(dataAgora.AddMonths(1)); // adiciona x mes

      var dataCriada = new DateTime(2006, 06, 19, 5, 20, 40);
      Console.WriteLine($"Nascimento Titi: {dataCriada}");

      if (dataAgora.Date == DateTime.Now.Date)
      {
        Console.WriteLine("Data é igual");
      }

      //Horarios globais (no google tem cultureInfo)
      var br = new CultureInfo("pt-BR");
      Console.WriteLine(DateTime.Now.ToString("D", br)); // ex: quarta-feira, 23 de novembro de 2022

      var en = new CultureInfo("en-US");
      Console.WriteLine(DateTime.Now.ToString("D", en)); //Wednesday, November 23, 2022

      var currentCulture = CultureInfo.CurrentCulture;
      Console.WriteLine(DateTime.Now.ToString("D", currentCulture)); //pega o culture da maquina (en-US)

      //

      var diasNoMes = DateTime.DaysInMonth(2022, 6);
      Console.WriteLine($"Dia no mês de: {diasNoMes}");  //pega os dias no mes do ano

      Console.WriteLine(DateTime.Compare(dataAgora, dataCriada)); // -1 antes, 0 igual, +1 depois

      Console.WriteLine(isWeekend(DateTime.Now.DayOfWeek));  //se data atual é finde

      Console.WriteLine(DateTime.Now.DayOfWeek.ToString());

    }

    public static bool isWeekend(DayOfWeek today)
    {
      return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
    }


  }




}