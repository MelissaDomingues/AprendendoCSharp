using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto  7 - Condicionais");

        string nome = "João";
        int idade = 22;
        int acompanhantes = 0;

        if (idade >= 18)
        {
            Console.WriteLine(nome + "...Pode entrar. Aproveite a festa!");
        }
        else
        {
            if (acompanhantes > 0) 
            {
                Console.WriteLine(nome + " está acompanhado (a), pode entrar!");
            }
            else
            {
                Console.WriteLine("Desculpe, mas " + nome + ",não pode entrar!");
            }
        }
          
       

        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }

}
