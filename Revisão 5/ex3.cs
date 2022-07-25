using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite a base e a altura do retângulo:");
    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    Console.WriteLine(Diagonal(b, h));
  }
  public static double Diagonal(double b, double h) {
    double diagonal = Math.Sqrt((b*b)+(h*h));
    return diagonal;
  }
}