using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite seu nome completo: ");
    string s = Console.ReadLine();
    string[] S = s.Split();
    Console.WriteLine("Bem vindo ao C#, " + S[0]);
  }
}