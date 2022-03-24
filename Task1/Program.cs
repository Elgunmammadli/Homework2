using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir.
            //Example1: 333= 73338

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

                Console.Write("4 reqemli eded daxil et :");
                int eded = Convert.ToInt32(Console.ReadLine());
                eded = Math.Abs(eded);
                string ededStr = Convert.ToString(eded);
                string evvel = "7";
                string sonra = "8";

                if (ededStr.Length==4)
                {

                    Console.WriteLine(evvel + eded + sonra);

                }
                else
                {
                    Console.WriteLine("Daxil etdiyin eded 4 reqemli deyil");
                }

            }
        }
    }
}
