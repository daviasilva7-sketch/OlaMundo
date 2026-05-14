//Antecessor e Sucessor  - produção de algoritmo para imprimir com número inteiro(2)

int numero;

int antecessor;

int sucessor;

      Console.WriteLine ( "Digite um número inteiro: ");
   
   numero = int.Parse (Console.ReadLine());

   antecessor = numero - 1;
   sucessor = numero + 1;

      Console.WriteLine ($"O antecessor de {numero} é {antecessor}");

      Console.WriteLine ($"O sucessor de {numero} é {sucessor}");