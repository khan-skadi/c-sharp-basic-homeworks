using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {

        static int SumOfEvens(int[] arrSix)
        {
            int result = 0;

            foreach (int i in arrSix)
                if (i % 2 == 0)
                {
                    result += i;
                }
            return result;
        }

        static void Main(string[] args)
        {
            int[] arrSix = new int[6];
            for (int i = 0; i < arrSix.Length; i++)
            {
                bool parse = int.TryParse(Console.ReadLine(), out arrSix[i]);
            }

            // Task 1
            int result = SumOfEvens(arrSix);
            Console.WriteLine("The sum of even numbers is: " + result);

            // Task 2
            string[] studentsG1 = { "Skadi", "Dave", "Red", "Yohannes", "Grubby" };
            string[] studentsG2 = { "Dejan", "Vukashin", "Monika", "Dusko", "Ivana" };
            Console.WriteLine("Enter student group: (there are 1 and 2)");
            int group = 0;
            bool task2Result = int.TryParse(Console.ReadLine(), out group);


            if (group == 1)
            {
                Console.WriteLine("StudentsG1: [Skadi, Dave, Red, Yohannes, Grubby]");
            }
            else
            {
                Console.WriteLine("StudentsG2: [Dejan, Vukashin, Monika, Dusko, Ivana]");
            }

            

            Console.ReadLine();
        }
    }
}
