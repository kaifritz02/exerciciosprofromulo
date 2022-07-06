using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.MatematicaBasica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercícios 1 - Crie na Solution um novo projeto com nome do ExerciciosProfRomulo.MatematicaBasica
             * Execício 2 - Crie na Solution um novo projeto com o nome de ExerciciosProfRomulo.EscolinhaTicTac
             * Exercício 3 - No projeto MatematicAbasica crie um Programa que calcule a soma de doismnumeros inteiros. Considere que o usuário vai digitar esses dois números.
             * 
             * 
             * 
             */
            int numberOne;
            int numberTwo;
            int sum;

            Console.WriteLine("Young man, enter two numbers:");
            numberOne = int.Parse(Console.ReadLine());
            numberTwo = int.Parse(Console.ReadLine());
            sum = numberOne + numberTwo;
            System.Console.WriteLine("The result of your sum is: " + sum);
            Console.ReadKey();
        }
    }
}
    
