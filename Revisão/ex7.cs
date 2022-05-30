using System;

public class Program {
  public static void Main(string[] args){
  Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double delta = Math.Pow(b, 2) - (4 * a * c);
    double R1 = (-b + Math.Sqrt(delta))/ 2 * a;
    double R2 = (-b - Math.Sqrt(delta))/ 2 * a;
if (delta < 0 || delta == 0 || a < 0) Console.WriteLine("impossível calcular");
    else Console.WriteLine($"As raízes são {R1} e {R2}");
 }
}