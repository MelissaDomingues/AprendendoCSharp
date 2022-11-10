using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro;
        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);
        //conversão de variável do tipo float para tipo inteiro. Sempre usar ()

        long x;
        x = 2000000000000000000;
        Console.WriteLine(x);
        //variável long suporta numeros maiores do que a int

        short y;
        y = 15000;
        Console.WriteLine(y);
        //variável short é tem menor capacidade e é usada para numeros "pequenos"

        float altura = 1.50f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();



        
        
    }

}

