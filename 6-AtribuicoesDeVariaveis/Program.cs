using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 6 - Atribuições de variáveis");

        int idade = 30;
        int idadeAna = idade;
        Console.WriteLine(idadeAna);

        idade = 25;
        //nesse caso o print continua sendo 30 enão 25
        //a leitura é feita de modo linear, então não da pra alterar o valor de uma variável que ja tem um valor (pelo ou menos até agora não rs)
        //"Variáveis guardam valores e não referências"


        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }

}
