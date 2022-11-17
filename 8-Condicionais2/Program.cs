using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto  7 - Condicionais");

        string nome = "João";
        int idade = 15;
        int acompanhantes = 2;

        if (idade >= 18 || acompanhantes > 0) 
        {
            Console.WriteLine(nome + "...Pode entrar. Aproveite a festa!");
        }
        else
        {
            Console.WriteLine("Desculpe, mas " + nome + ",não pode entrar!");            
        }
        //diferente do exercício anterior, aqui foi usado "ou" representado por "||"
        //isso descarta a necessidade de criar outro if and else no código, deixando mais limpo e mais simples.



        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }

}

