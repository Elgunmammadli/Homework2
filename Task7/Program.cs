using System;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  7) 2 dene 5 reqemli eded verilib.Bu ededleri toplayib.
            //  Alinan cavabin evveline ve axirina 5 artir.Neticenin 5 % tap

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

                Console.Write("ilk 5 reqemli ededi daxil et :");
                int eded = Convert.ToInt32(Console.ReadLine());

                Console.Write("ikinci 5 reqemli ededi daxil et :");
                int eded2 = Convert.ToInt32(Console.ReadLine());
                eded = Math.Abs(eded);
                eded2 = Math.Abs(eded2);
                string ededStr = Convert.ToString(eded);
                string eded2Str = Convert.ToString(eded2);
                string besh = "5";
                int cem = eded + eded2;
                string beforeAfterBesh = besh + cem + besh;
                double nextBeforeAfterBesh = Convert.ToDouble(beforeAfterBesh)*1.0*5/100;





                if (ededStr.Length == 5 && eded2Str.Length==5)
                {
                    Console.WriteLine($"evveline ve sonuna 5 elave edende :{beforeAfterBesh}");
                    Console.WriteLine($"alinan ededin 5 faizi : {nextBeforeAfterBesh}");


                }
                else if(ededStr.Length!=5)
                {
                    Console.WriteLine("Daxil etdiyiniz birinci eded 5 reqemli deyil");
                }
                else if (eded2Str.Length != 5)
                {
                    Console.WriteLine("Daxil etdiyiniz ikinci eded 5 reqemli deyil");
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz ededler 5 reqemli deyil !");

                }
            }
        }
    }
}
