usando  Sistema ;
 Programa de classe  pública {
  public  static  void  Main ( string [] args )
  {
    Consola . WriteLine ( " Digite dois valores inteiros separados por um operador +,-,*,/ " );
    string  lista  =  Console . ReadLinha ();
    char [] sinal  = { '+' , '-' , '*' , '/' };
    char [] numeros  = { '0' , '1' , '2' , '3' , '4' , '5' , '6' , '7' , '8' , '9' };

    string [] numero  =  lista . Split ( sinal );
    string [] operador  =  lista . Divisão ( números );
    
    Consola . WriteLine ( operador [ 0 ]);
    Consola . WriteLine ( numero [ 0 ]);
  }
}