﻿using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula poupança 2 " );

        double investimento = 1000;

        int mes = 1;

        while (mes <= 12)  
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);

            mes = mes + 1; 
        }

        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    } 


}