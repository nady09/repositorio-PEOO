using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine();
    string[] v = s.Split();
    int n = 0;
    while (n < v.Length) {
      int i = n;
      while(i < v.Length) {
        Console.Write(v[i] + " ");
        i++;
      }
      Console.WriteLine();
      n++;
    }
  } 
}