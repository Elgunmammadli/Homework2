using System;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  10) 3 dene 4 reqemli eded verilib.
            //  I ededin 1%-ni,
            //  II ededin 2% ,
            //  III ededin 3 % tap.
            //  Neticeleri bir birinden cix.
            //  Alinan cavabin ustune III ededin 7 % faizini gel

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

                Console.Write("birinci 4 reqemli ededi daxil et :");
                int eded = Convert.ToInt32(Console.ReadLine());

                Console.Write("ikinci 4 reqemli ededi daxil et :");
                int eded2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("3cu 4 reqemli ededi daxil et :");
                int eded3 = Convert.ToInt32(Console.ReadLine());

                eded = Math.Abs(eded);
                eded2 = Math.Abs(eded2);
                eded3 = Math.Abs(eded3);

                string ededStr = Convert.ToString(eded);
                string eded2Str = Convert.ToString(eded2);
                string eded3Str = Convert.ToString(eded3);

                double birFaiz = eded * 1.0 * 1 / 100;
                double ikiFaiz = eded2 * 1.0 * 2 / 100;
                double ucFaiz = eded3 * 1.0 * 3 / 100;
                double ucuncu7 = eded3 * 1.0 * 7 / 100;

                double substract = birFaiz - ikiFaiz - ucFaiz;
                double son = substract + ucuncu7;


                if (ededStr.Length == 4 && eded2Str.Length == 4 && eded3Str.Length == 4)
                {
                    Console.WriteLine($"Birinci ededin 1 faizi : {birFaiz}");
                    Console.WriteLine($"Ikinci ededin 2 faizi : {ikiFaiz}");
                    Console.WriteLine($"3cu ededin 3 faizi : {ucFaiz}");

                    Console.WriteLine($"Ferqi: {substract}");


                    Console.WriteLine($"Ferqi ile 3cu ededin 7faizinin cemi : {son}");


                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz ededler uygun deyil !");

                }
            }
        }
    }
}
