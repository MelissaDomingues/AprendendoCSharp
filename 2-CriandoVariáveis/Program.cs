using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 -Criando Variáveis");
        int idade;
        idade = 20;
        Console.WriteLine("Minha idade é " + idade);

        idade = 20 - 5;
        Console.WriteLine("Mas ha cinco anos, eu tinha " + idade);

        idade = (4 + 4) * 2 + 2;
        Console.WriteLine("E foi com " + idade + " que eu comecei a me interessar pela programação");

        idade = 42 / 2;
        Console.WriteLine("...Com " + idade + " eu ja quero estar trabalhando com isso!");

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine(); 
    }

}
