using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite o raio do círculo:");
    double raio = double.Parse(Console.ReadLine());
    Console.WriteLine(AreaCirculo(raio));
  }
  public static double AreaCirculo(double raio) {
    double area = 3.14 * (raio * raio);
    return area;
  }
}