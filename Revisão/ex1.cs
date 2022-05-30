using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Introduza x: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("Introduza y: ");
    int y = int.Parse(Console.ReadLine());

    if (x > y)
    {
        Console.WriteLine(x + " é maior do que " + y);
    }
    else
    {
        if (x == y)
        {
            Console.WriteLine("valores iguais");
        }
        else
        {
            Console.WriteLine(y + " é maior do que " + x);
        }
    }
}
  }