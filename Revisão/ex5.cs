using System;

public class Program {
  public static void Main(string[] args){
Console.WriteLine("Informe o número do mês");
    int m = int.Parse(Console.ReadLine());
    if (m == 1) Console.WriteLine("O mês de janeiro é do primeiro trimestre do ano");
    if (m == 2) Console.WriteLine("O mês de fevereiro é do primeiro trimestre do ano");
    if (m == 3) Console.WriteLine("O mês de março é do primeiro trimestre do ano");
    if (m == 4) Console.WriteLine("O mês de abril é do segundo trimestre do ano");
    if (m == 5) Console.WriteLine("O mês de maio é do segundo trimestre do ano");
    if (m == 6) Console.WriteLine("O mês de junho é do segundo trimestre do ano");
    if (m == 7) Console.WriteLine("O mês de julho é do terceiro trimestre do ano");
    if (m == 8) Console.WriteLine("O mês de agosto é do terceiro trimestre do ano");
    if (m == 9) Console.WriteLine("O mês de setembro é do terceiro trimestre do ano");
    if (m == 10) Console.WriteLine("O mês de outubro é do quarto trimestre do ano");
    if (m == 11) Console.WriteLine("O mês de novembro é do quarto trimestre do ano");
    if (m == 12) Console.WriteLine("O mês de dezembro é do quarto trimestre do ano");
 }
}