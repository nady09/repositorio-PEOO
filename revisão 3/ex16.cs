using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma frase:");
    string t = Console.ReadLine().ToLower();
    int x = t.Length;
    int i = 0;
    int sA = 0;
    int sE = 0;
    int sI = 0;
    int sO = 0;
    int sU = 0;
    while(i < x){
      if(t[i] == 'a') sA++;
      if(t[i] == 'e') sE++;
      if(t[i] == 'i') sI++;
      if(t[i] == 'o') sO++;
      if(t[i] == 'u') sU++;
      i++;
    }
    Console.WriteLine($"A - {sA}");
    Console.WriteLine($"E - {sE}");
    Console.WriteLine($"I - {sI}");
    Console.WriteLine($"O - {sO}");
    Console.WriteLine($"U - {sU}");
  }
}