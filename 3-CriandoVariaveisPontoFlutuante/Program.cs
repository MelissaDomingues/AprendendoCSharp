using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis e Ponto Flutuante");

        double salario;
        salario = 1245.45;
        Console.WriteLine("O salário naquela empresa é de " + salario);

        Console.WriteLine("Tecle enter para continuar...");
        Console.ReadLine();

        int divisao = 7/5;
        Console.WriteLine("Exemplo de divisão usando int: " + divisao);

        double divisao2 = 7.0 / 5;
        Console.WriteLine("Exemplo de divisão double: " + divisao2);
        Console.WriteLine("Nos dois exemplos foram usados os mesmos números = 7/5.");

        Console.WriteLine("Tecle enter para encerrar");       
    }

}

