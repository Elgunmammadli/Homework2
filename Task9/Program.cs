using System;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  9) 3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla.
            //  Alinan cavabin 10% tap.

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

                Console.Write("birinci 6 reqemli ededi daxil et :");
                int eded = Convert.ToInt32(Console.ReadLine());

                Console.Write("ikinci 6 reqemli ededi daxil et :");
                int eded2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("3cu 6 reqemli ededi daxil et :");
                int eded3 = Convert.ToInt32(Console.ReadLine());

                eded = Math.Abs(eded);
                eded2 = Math.Abs(eded2);
                eded3 = Math.Abs(eded3);

                string ededStr = Convert.ToString(eded);
                string eded2Str = Convert.ToString(eded2);
                string eded3Str = Convert.ToString(eded3);

                double birinciOn = eded * 1.0 * 10 / 100;
                double ikinciOn = eded2 * 1.0 * 10 / 100;
                double ucuncuOn = eded3 * 1.0 * 10 / 100;

                double cem = birinciOn + ikinciOn + ucuncuOn;
                double cemOn = cem * 1.0 * 10 / 100;




                if (ededStr.Length == 6 && eded2Str.Length == 6 && eded3Str.Length == 6)
                {
                    Console.WriteLine($"Birinci ededin 10 faizi : {birinciOn}");
                    Console.WriteLine($"Ikinci ededin 10 faizi : {ikinciOn}");
                    Console.WriteLine($"3cu ededin 10 faizi : {ucuncuOn}");

                    Console.WriteLine($"Cemi: {cem}");


                    Console.WriteLine($"Ceminin 10 faizi : {cemOn}");


                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz ededler uygun deyil !");

                }
            }
        }
    }
}
