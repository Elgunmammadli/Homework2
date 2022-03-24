using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) 5 reqemli eded verilib.Bu ededin evvel 18 % sonra ise 3 % tap

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

                Console.Write("5 reqemli eded daxil et :");
                int eded = Convert.ToInt32(Console.ReadLine());
                double c = eded*1.0 * 18 / 100;
                double c2 = eded * 1.0 * 3 / 100;
                eded = Math.Abs(eded);
                string ededStr = Convert.ToString(eded);

                if (ededStr.Length == 5)
                {

                    Console.WriteLine($"{eded}-in 18 faizi: {c}");
                    Console.WriteLine($"{eded}-in 3 faizi: {c2}");

                }
                else
                {
                    Console.WriteLine("Daxil etdiyin eded 5 reqemli deyil");
                }

            }
        }
    }
}
