using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite o raio da esfera:");
    double r = double.Parse(Console.ReadLine());
Console.WriteLine(VolumeEsfera(r));
  }
  public static double VolumeEsfera(double r) {
    double volume = 4.0/3 * 3.14 * (r * r * r);
    return volume;
  }
}  