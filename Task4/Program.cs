using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) 3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;

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
                string sonra = "7";
                string eded2 = eded + sonra;
                int newEded = Convert.ToInt32(eded2);
                double yeddi = newEded * 1.0 * 7 / 100;

                if (ededStr.Length == 3)
                {
                    Console.WriteLine($"{newEded}-in 7 faizi : {yeddi}");
                }
                else
                {
                    Console.WriteLine("Daxil etdiyin eded 3 reqemli deyil");
                }

            }
        }
    }
}
