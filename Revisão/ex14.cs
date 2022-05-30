using System;
public class Program {
  public static void Main(string[] args) {
    
    Console.WriteLine("Digite três valores:");
    
    int a =int.Parse(Console.ReadLine());
    int b =int.Parse(Console.ReadLine());
    int c =int.Parse(Console.ReadLine());

    if(a + b > c && a + c > b && b + c > a){
        Console.WriteLine("Os 3 lados formam um triangulo!\n");
        if(a == b && a == c)
            Console.WriteLine("Equilatero\n");
        else
            if(a == b || a == c || b == c)
                Console.WriteLine("Isosceles\n");
            else
                Console.WriteLine("Escaleno\n");
    }
    else
        Console.WriteLine("Esses valores não formam um triângulo\n");
       
  }  
}