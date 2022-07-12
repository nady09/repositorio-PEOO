using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma frase:");
    string t = Console.ReadLine();
    int x = t.Length;
    int i = 1;
    string c = "";
    while(x >= i){
      c += t.Substring(x-1);
      t = t.Remove(x-1);
      x--;
    }
    Console.WriteLine(c);
  }
}