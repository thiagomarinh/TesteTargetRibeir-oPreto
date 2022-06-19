using System;

class Program 
{
  public static void Main (string[] args) 
  {
    //QUESTÂO 01 RESPOSTA 91
    int INDICE = 13, SOMA = 0, K = 0;

    while (K < INDICE)
    {
      K = K + 1;
      SOMA = SOMA + K;
    }
    Console.WriteLine(SOMA);    

    //QUESTÃO 03
    // a) 1, 3, 5, 7, ___9

    // b) 2, 4, 8, 16, 32, 64, ___122

    // c) 0, 1, 4, 9, 16, 25, 36, ____49

    // d) 4, 16, 36, 64, ____100

    // e) 1, 1, 2, 3, 5, 8, ____13

    // f) 2,10, 12, 16, 17, 18, 19, ____200


    //QUESTÂO 04
    fibonacci();
    inverter();
    
  }
  //QUESTÂO 05 chamei o metodo inverter logo acima
  public static void inverter()
  {
    string texto = "oi";
    char[] textoArray = texto.ToCharArray();
    char n = textoArray[0];
    textoArray[0] = textoArray[1];
    textoArray[1] = n;
    Console.WriteLine(textoArray);
    
  } 

  // Quetão 02
  public static void fibonacci()
  {
    int j = 1;
    int x = 0;
    int soma;
    Console.WriteLine("Digite um numero para saber se está na sequencia de fibonacci: ");
    int n = int.Parse(Console.ReadLine());

      for (int i = 0; i < 1000; i++)
      {
        soma = x + j;
        j = x;
        x = soma;
          if (soma == n)
          {
            Console.WriteLine($"O numero {n} contem na sequencia!!!");
          }
          else
          {
            Console.WriteLine($"O numero {n} não contem na sequencia");
          }
      }
  }
}