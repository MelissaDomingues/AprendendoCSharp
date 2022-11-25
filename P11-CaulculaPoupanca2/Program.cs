using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula poupança 2 ");

       
        double investimento = 1000;
       
        for (int mes = 1; mes <= 12; mes = mes + 1)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
        }

        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }


}
