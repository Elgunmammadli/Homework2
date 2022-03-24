using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) 4 reqemli eded verilib.Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir.
            // Alinan cavabin 44 % tap.

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
                string evvel = "4";
                string sonra = "44";
                string eded2 = evvel+eded + sonra;
                int newEded = Convert.ToInt32(eded2);
                double yeddi = newEded * 1.0 * 44 / 100;

                if (ededStr.Length == 4)
                {
                    Console.WriteLine($"{newEded}-in 44 faizi : {yeddi}");
                }
                else
                {
                    Console.WriteLine("Daxil etdiyin eded 4 reqemli deyil");
                }

            }
        }
    }
}
