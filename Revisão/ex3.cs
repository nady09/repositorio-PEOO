using System;

public class Program{

 public static void Main(string[] args){
Console.WriteLine("Digite quatro valores inteiros");
string s= Console.ReadLine();
int a = int.Parse(s);
int b = int.Parse(Console.ReadLine()); 
int c = int.Parse(Console.ReadLine()); 
int d = int.Parse(Console.ReadLine());
int par = 0;
int impar = 0;
if (a % 2 == 0) par = par + a;
   else impar = impar + a;
if (b % 2 == 0) par = par + b;
   else impar = impar + b;
if (c % 2 == 0) par = par + c;
   else impar = impar + c;
if (d % 2 == 0) par = par + d;
   else impar = impar + d;
Console.WriteLine($"Soma dos pares = {par}");
Console.WriteLine($"Soma dos ímpares = {impar}");
 }
}