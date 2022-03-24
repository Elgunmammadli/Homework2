using System;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  8) 2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
            //  I ededin 4 % -ni tap.
            //  Sonra II ededin 9 % ni tap.
            //  Sonra Cavalari toplayib 10 % ni tap.

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

                Console.Write("4 reqemli ededi daxil et :");
                int eded = Convert.ToInt32(Console.ReadLine());

                Console.Write("7 reqemli ededi daxil et :");
                int eded2 = Convert.ToInt32(Console.ReadLine());
                eded = Math.Abs(eded);
                eded2 = Math.Abs(eded2);
                string ededStr = Convert.ToString(eded);
                string eded2Str = Convert.ToString(eded2);
                double birinciDort = eded * 1.0 * 4 / 100;
                double ikinciDoqquz = eded2 * 1.0 * 9 / 100;
                double cem = (birinciDort + ikinciDoqquz)*1.0*10/100;




                if (ededStr.Length == 4 && eded2Str.Length == 7)
                {
                    Console.WriteLine($"Birinci ededin 4 faizi : {birinciDort}");
                    Console.WriteLine($"Ikinci ededin 9 faizi : {ikinciDoqquz}");
                    Console.WriteLine($"Ceminin 10 faizi : {cem}");


                }
                else if (ededStr.Length != 4)
                {
                    Console.WriteLine("Daxil etdiyiniz birinci eded 4 reqemli deyil");
                }
                else if (eded2Str.Length != 7)
                {
                    Console.WriteLine("Daxil etdiyiniz ikinci eded 7 reqemli deyil");
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz ededler uygun deyil !");

                }
            }
        }
    }
}
