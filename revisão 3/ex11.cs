sing System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma frase:");
    string t = Console.ReadLine();
    int x = t.Length;
    int i = 0;
    int s = 0;
    while(i < x){
      if(t[i] == '1') s += 1;
      if(t[i] == '2') s += 2;
      if(t[i] == '3') s += 3;
      if(t[i] == '4') s += 4;
      if(t[i] == '5') s += 5;
      if(t[i] == '6') s += 6;
      if(t[i] == '7') s += 7;
      if(t[i] == '8') s += 8;
      if(t[i] == '9') s += 9;
      i++;
    }
    Console.WriteLine(s);
  }
}