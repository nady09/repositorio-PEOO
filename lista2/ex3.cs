using System;

public class Program {

  public static void Main(string[] args)  {
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
      int a = int.Parse(Console.ReadLine());
      int A = a * 2;
    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
      int b = int.Parse(Console.ReadLine());
      int B = b * 3;
      int x = (A + B)/5;
    Console.WriteLine($"Média parcial = {x}");
  }