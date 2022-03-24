using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) 3 reqemli eded verilib.Bu ededin axirina hemin ededdin ozunu yapishdir.
            //example: 333 = 333333;

            string inputAnswer;
            bool continueWhile;

            while (true)
            {
                Console.Write("Start (Y/N) :");
                inputAnswer = Convert.ToString(Console.ReadLine());
                continueWhile = inputAnswer == "Y" || inputAnswer == "y";
                if (continueWhile == false)
                {
                    Console.WriteLine("Exited");
                    break;
                }

                Console.Write("3 reqemli eded daxil et :");
                int eded = Convert.ToInt32(Console.ReadLine());
                eded = Math.Abs(eded);
                string ededStr = Convert.ToString(eded);
                string sonra = Convert.ToString(eded);

                if (ededStr.Length==3)
                {

                    Console.WriteLine( eded + sonra);

                }
                else
                {
                    Console.WriteLine("Daxil etdiyin eded 3 reqemli deyil");
                }

            }
        }
    }
}
