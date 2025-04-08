using System;
using System.Globalization; //importa a cultura variável

namespace SISTEMADEALUNO

//4. Exercício: Maior Número 
//Solicite dois números ao usuário e exiba na tela qual deles é o maior.
//Utilize estruturas condicionais como if para fazer a verificação
{
    class Exercicio4
    {
    static void Main(string[] args) //método que executa o programa
    {
        Console.WriteLine("Digite 2 números: "); 
        double num1 = Convert.ToDouble((Console.ReadLine()));
        double num2 = Convert.ToDouble((Console.ReadLine()));
            
        if (num1 > num2) {
        Console.WriteLine("O maior número é: " + num1 + ".");          
        } else if (num2 > num1) {
            Console.WriteLine("O maior número é: "+ num2 + ".");
        } else 
            Console.WriteLine("Os números são iguais.");
        }
    }

}