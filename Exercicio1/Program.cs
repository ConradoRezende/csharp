using System;
using System.Globalization; //importa a cultura variável

namespace SISTEMADEALUNO

//1. Exercício: Nome e Saudação
//Peça ao usuário que digite seu nome e, em seguida, exiba uma saudação personalizada utilizando o nome inserido

{
    class Exercicio1
    {
        static void Main(string[] args) //método que executa o programa
        {
            Console.WriteLine("Digite seu nome: "); //Exibe mensagem pedindo o nome do aluno
            string nome = Console.ReadLine(); //Lê o nome digitado e armazena a variável "nome"
            
            Console.WriteLine("Seja bem-vindo " + nome + ".");
            
        }
    }
}
