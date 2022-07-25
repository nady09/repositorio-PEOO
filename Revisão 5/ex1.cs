using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite dois valores:");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = Menor(a, b);
    Console.WriteLine(c);
  }
  public static double Menor(double x, double y) {
    if (x < y)return x;
    else return y;
    }
  }
