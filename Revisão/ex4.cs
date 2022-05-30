using System;

public class Program{
  
  public static void Main(string[] args){
Console.WriteLine("Digite o primeiro horário no formato hh:mm");
  string s = Console.ReadLine();
  string[] v = s.Split(":");
  int h1 = int.Parse(v[0]);
  int m1 = int.Parse(v[1]);
Console.WriteLine("Digite o segundo hor ário no formato hh:mm");
  string x = Console.ReadLine();
  string[] y = x.Split(":");
  int h2 = int.Parse(y[0]);
  int m2 = int.Parse(y[1]);

  int min = m1 + m2;
  int h = h1 + h2;
    if (min >= 60){
      min = min - 60;
      h += 1;
    } 

      Console.WriteLine($"Total de horas = {h:00}:{min:00}");
  }
}