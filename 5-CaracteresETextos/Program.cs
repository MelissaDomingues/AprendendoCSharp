using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

        char letra = 'a';
        Console.WriteLine(letra);
        //o valor dessa variável deve estar em aspas simples, e não duplas

        letra = (char)65;
        Console.WriteLine(letra);
        //código ascii também funciona

        letra = (char)(65 + 1);
        Console.WriteLine(letra);
        //no caso de códigos ascii, é possível fazer operçaões para indicar uma letra ou caracter.

        string meuNome = "Me chamo Melissa Rios ";
        Console.WriteLine(meuNome);
        //valor dessa variável deve ser declarada com aspas duplas, ja que se trata de texto

        Console.WriteLine(meuNome + "Domingues");
        //para adicionar informações a uma variável ja declarada, basta adicionar "+"...
        //no caso de texto, deve-se usar aspas duplas

        string familia = @"
- Fernando, 
- Sabrina, 
- Giulia, 
- Melissa,
- Rafaela";
        Console.WriteLine("Nome da minha familia  em ordem de idade" + familia);
        //usar o @ antes das aspas duplas para indicar uma lista. O espaço da indentação é contado nessa variável
                 
               

        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }

}

