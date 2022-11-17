using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto  7 - Condicionais");

        string nome = "João";
        int idade = 15;
        int acompanhantes = 1;
        
        bool acompanhado = acompanhantes > 0;
        
        string textoAdicional;
         
        if(acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "João não está acompanhado";
        }

        if(idade >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine(nome + "...Pode entrar. Aproveite a festa!");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Desculpe, mas " + nome + ", não pode entrar!");
        }
        //o sinal de "==" significa comparação e não atribuição de valor.
        //Ele verifica se o valor de uma variável é igual a condição estabelecida
        //bool 0 ou 1 (true or false)



        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }

}
