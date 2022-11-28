using System;

namespace CSharp_BaltaIio
{
  class Inteiro
  {
    public short num_short { get; set; }    //-32768 to 32767
    public ushort num_ushort { get; set; }  //0 to 65535
    public int num_inteiro { get; set; }    //-2.147.483.648 to 2.147.483.647
    public uint num_uinteiro { get; set; }  //0 to 4.294.967.295
    public long num_long { get; set; }      //-9.223... to 9.223....
    public ulong num_ulong { get; set; }    //0 to 18.446.744....
  }
}

