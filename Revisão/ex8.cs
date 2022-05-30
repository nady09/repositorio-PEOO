using System;

public class Program {

public static void Main(string[] args) { 
  Console.WriteLine("Digite quatro valores inteiros");
    int a = int.Parse(Console.ReadLine()); 
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine()); 
    int d = int.Parse(Console.ReadLine());
    int maior = 0;
    int menor = 0;
    int maior2 = 0;
    int menor2 = 0;
  
  if (a != b && a != c && a != d && b != c && b != d && c != d) {
    if (a > b && a > c && a > d) maior = a;
    if (b > a && b > c && b > d) maior = b;
    if (c > a && c > b && c > d) maior = c;
    if (d > a && d > b && d > c) maior = d;
    Console.WriteLine($"Maior valor = {maior}"); 
    if (a < b && a < c && a < d) menor = a;
    if (b < a && b < c && b < d) menor = b;
    if (c < a && c < b && c < d) menor = c;
    if (d < a && d < b && d < c) menor = d;
    Console.WriteLine($"Menor valor = {menor}");
    if (a < maior && a > menor) maior2 = a;
    if (b < maior && b > menor) maior2 = b;
    if (c < maior && c > menor) maior2 = c; 
    if (d < maior && d > menor) maior2 = d;

    if (a < maior && a > menor && a != maior2) menor2 = a; 
    if (b < maior && b > menor && b != maior2) menor2 = b;
    if (c < maior && c > menor && c != maior2) menor2 = c;
    if (d < maior && d > menor && d != maior2) menor2 = d;
    Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {maior2+ menor2}"); 
  }
    else Console.WriteLine("Erro: valores inválidos");
 }
}