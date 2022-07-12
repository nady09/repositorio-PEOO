using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine();
    int i = 1;
    while (i <= s.Length) {
      s = s.Substring(1) + s.Substring(0, 1);
      Console.WriteLine(s);
      i++;
    }
  }
}