using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite o valor da base");
     string s = Console.ReadLine(); 
     double b = double.Parse(s);
    
    Console.WriteLine("Digite o valor da altura");
     string r = Console.ReadLine();
     double h = double.Parse(r);
    
     double a = b * h;
     double p = b*2 + h*2;
     double D = b*b + h*h;
     double d = Math.Sqrt(D);
    
    Console.WriteLine($"Área do retângulo = {a:0.00}");
    Console.WriteLine($"Perimetro do retângulo = {p:0.00}");
    Console.WriteLine($"Diagonal do retângulo = {d:0.00}");
  }
}