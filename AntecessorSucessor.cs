int numero1;

int numero2;

int soma;

int subtracao;

int divisao;

int multiplicacao;

    Console.Write ("Informe um número: ");

numero1 = int.Parse (Console.ReadLine());

    Console.Write ("Informe um número 2: ");

numero2 = int.Parse (Console.ReadLine());

soma = numero1 + numero2;
 subtracao = numero1 - numero2;
  divisao = numero1 / numero2;
   multiplicacao = numero1 * numero2;

    Console.WriteLine ($ "A soma é {soma}");
    Console.WriteLine ($ "A subtração é {subtracao}");
    Console.WriteLine ($ "A divisão é {divisao}");
    Console.WriteLine ($ "A multiplicação é {multiplicacao}");
