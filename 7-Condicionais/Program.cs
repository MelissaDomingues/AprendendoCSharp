using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto  7 - Condicionais");

        string nome = "João";
        int idade = 12;
        int acompanhantes = 2;

        bool acompanhado = acompanhantes > 1;
        bool grupo = true;


        if (idade >= 18 || acompanhantes > 1)
        {
            Console.WriteLine(nome + "...Pode entrar. Aproveite a festa!");
        }
        else
        {
            Console.WriteLine("Desculpe, mas " + nome + ",não pode entrar!");            
        }



        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }

}
