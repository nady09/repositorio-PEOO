using System; 

public class Program {

  public static void Main(string[] args) {
    int x = 1;
    while(x <= 30) {
      if (x % 3 == 0) Console.WriteLine(-x);
        else Console.WriteLine(x);
      x++;
    }
  }
}
