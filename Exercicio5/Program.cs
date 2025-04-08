using System;
using System.Globalization; //importa a cultura variável

namespace SISTEMADEALUNO

//5. Exercício: Verificar Par ou Ímpar
//Peça ao usuário que digite um número e informe se ele é par ou ímpar.
//Dica: Utilize o operador % (módulo) para verificar se o resto da divisão por 2 é igual a 0.

{
    class Exercicio5
    {
    static void Main(string[] args) //método que executa o programa
    {
        Console.WriteLine("Digite um número: "); 
        double num = Convert.ToDouble((Console.ReadLine()));
                    
        if (num % 2 == 0) {
        Console.WriteLine("O número " + num + " é par.");          
        } else {
            Console.WriteLine("O número é impar.");
        }
    }
    }
}