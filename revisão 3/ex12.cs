using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma frase:");
    string t = Console.ReadLine();
    string[] v = t.Split();
    int x = v.Length;
    Console.WriteLine(x);
  }
}