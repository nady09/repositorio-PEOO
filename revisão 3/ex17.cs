using System; 

public class Program {

  public static void Main(string[] args) {
     Console.WriteLine("Digite Uma Frase:");
    string t = Console.ReadLine();
    string [] v = t.Split();
    foreach(string p in v){
      int soma = 0;
      int i = 0;
      while(i < p.Length){
        if(p[i] == 'a' || p[i] == 'e' || p[i] == 'i' || p[i] == 'o' || p[i] == 'u'){
          soma++;
        }
        i++;
      }
      i = 0;
      while(i < soma){
        Console.Write(p + " ");
        i++;
      }
    }
  }
}