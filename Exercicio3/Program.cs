using System;
using System.Globalization; //importa a cultura variável

namespace SISTEMADEALUNO

//3. Peça ao usuário para digitar três notas. Em seguida, calcule e exiba a média aritmética dessas notas.
//Lembre-se de usar double para permitir valores decimais2. Exercício: Calculando a Idade

{
    class Exercicio3
    {
        static void Main(string[] args) //método que executa o programa
        {
            Console.WriteLine("Digite 3 notas diferentes: "); 
            double nota1 = Convert.ToDouble((Console.ReadLine()));
            double nota2 = Convert.ToDouble((Console.ReadLine()));
            double nota3 = Convert.ToDouble((Console.ReadLine()));

            double media = (nota1 + nota2 + nota3)/3;
            
            Console.WriteLine("Média: " + media + ".");            
        }
    }
}
