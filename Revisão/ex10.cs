using System;

public class Program {
  public static void Main(string[] args){
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string s = Console.ReadLine();
    string[] v = s.Split("/");
    int d = int.Parse(v[0]);
    int m = int.Parse(v[1]);
    int a = int.Parse(v[2]);

    if (1900 <= a && a <= 2100){
      if (m == 01 || m == 03 || m == 05 || m == 07 || m == 08 || m == 10 || m == 12) {
        if (1 <= d && d <= 31) Console.WriteLine("A data informada é válida");
          else Console.WriteLine("A data informada não é válida");
        }
      if (m == 02) {
        if (1 <= d && d <= 28) Console.WriteLine("A data informada é válida");
          else Console.WriteLine("A data informada não é válida");
      }
      if (m == 04 || m == 06 || m == 09 || m == 11 ) {
        if (1 <= d && d <= 30) Console.WriteLine("A data informada é válida");
          else Console.WriteLine("A data informada não é válida");
      }
    }
      else Console.WriteLine("A data informada não é válida");
  }
}