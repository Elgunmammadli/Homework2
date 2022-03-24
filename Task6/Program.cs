using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {

          //  6) 4 reqemli eded verilib.Bu ededin evvel 20 % -ni , sonra ise cavabin 10 % tap.
          //  Alinan cavabin kvadratini tap.

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
                double first = (eded*1.0 * 20 / 100);
                double second = (first * 10 / 100);
                double third = Math.Pow(second, 2);
                third = Math.Round(third,6);



                if (ededStr.Length == 4)
                {
                    Console.WriteLine($"birinci cavab : {first}");
                    Console.WriteLine($"ikinci cavab : {second}");
                    Console.WriteLine($"Cavabin kvadrati : {third}");


                }
                else
                {
                    Console.WriteLine("Daxil etdiyin eded 4 reqemli deyil");
                }

            }
        }
    }
}
