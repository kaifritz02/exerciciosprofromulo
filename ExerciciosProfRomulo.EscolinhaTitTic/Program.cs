using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.EscolinhaTicTic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name;
            Console.WriteLine("Hello student! Before we start please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your first grade: ");
            int gradeOne;
            gradeOne = int.Parse(Console.ReadLine());
            int gradeTwo;
            gradeTwo = int.Parse(Console.ReadLine());
            int gradeThree;
            gradeThree = int.Parse(Console.ReadLine());
            double result = gradeOne + gradeTwo + gradeThree/3;

            if (result >= 7)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(name + " , your avarage grade is: " + result + ". So you got approved. Congratulations!");
            }
            else if (result >= 3 && result <= 7)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(name + ", your avarage grade is: " + result + ". So you need to do a recover. Please study more!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(name + ", your avarage grade is: " + result + ". So you failed. Please study more!");
            }
            Console.ReadKey();

        }
    }
}
