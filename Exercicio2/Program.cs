using System;
using System.Globalization; //importa a cultura variável

namespace SISTEMADEALUNO

//2. Exercício: Calculando a Idade
//Solicite que o usuário informe o seu ano de nascimento e calcule a idade considerando o ano atual como 2024.

{
    class Exercicio2
    {
        static void Main(string[] args) //método que executa o programa
        {
            Console.WriteLine("Informe o seu ano de nascimento: "); //Exibe mensagem pedindo o nome do aluno
            int anoNasc = int.Parse(Console.ReadLine()); //Lê o nome digitado e armazena a variável "nome"
            
            int idade = 2024 - anoNasc;

            Console.WriteLine("Idade: " + idade + ".");
            
        }
    }
}
