using System; 

public class Program {

  public static void Main(string[] args) {
     Console.WriteLine("Digite uma sequência de números separados por vírgula:");
    string t = Console.ReadLine();
    string[] v = t.Split(',');
    int x = v.Length;
    int i = 0;
    int s = 0;
    while(i < x){
      s += int.Parse(v[i]);
      i++;
    }
    Console.WriteLine(s);
  }
}