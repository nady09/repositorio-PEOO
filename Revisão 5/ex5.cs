using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite a altura, a largura e a profundidade de uma caixa d'água:");
    double h = double.Parse(Console.ReadLine());
    double l = double.Parse(Console.ReadLine());
    double p = double.Parse(Console.ReadLine());
Console.WriteLine(VolumeLitros(h, l, p));
  }
  public static double VolumeLitros(double h, double l, double p) {
    double volumelitros = (h * l * p) * 1000;
    return volumelitros;
  }
}