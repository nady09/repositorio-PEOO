using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string s = Console.ReadLine();
    string[] v = s.Split("/");
    int d = int.Parse(v[0]);
    int m = int.Parse(v[1]);
    int a = int.Parse(v[2]);
    
    if (m == 01) Console.WriteLine($"A  data é {d} de Janeiro de {a}");
    if (m == 02) Console.WriteLine($"A  data é {d} de Fevereiro de {a}");
    if (m == 03) Console.WriteLine($"A  data é {d} de Março de {a}");
    if (m == 04) Console.WriteLine($"A  data é {d} de Abril de {a}");
    if (m == 05) Console.WriteLine($"A  data é {d} de Maio de {a}");
    if (m == 06) Console.WriteLine($"A  data é {d} de Junho de {a}");
    if (m == 07) Console.WriteLine($"A  data é {d} de Julho de {a}");
    if (m == 08) Console.WriteLine($"A  data é {d} de Agosto de {a}");
    if (m == 09) Console.WriteLine($"A  data é {d} de Setembro de {a}");
    if (m == 10) Console.WriteLine($"A  data é {d} de Outubro de {a}");
    if (m == 11) Console.WriteLine($"A  data é {d} de Novembro de {a}");
    if (m == 12) Console.WriteLine($"A  data é {d} de Dezembro de {a}");
  }
}