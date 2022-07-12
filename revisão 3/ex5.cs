using System; 

public class Program {

  public static void Main(string[] args) {
    int x = 1;
    int y = 0;
    while(x <= 45) {
      x = x + y;
      Console.WriteLine(x);
      y++;
    }
  }
}
