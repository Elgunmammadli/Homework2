using System;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  12) 4 dene 6 reqemli eded verilib.
            //  Ededlerin hamisinin 10 faizini tap ve topla.
            //  Sonra hamisinin 15 faizini tap ve topla.
            //  Sonra yekunda alinanlar iki cavabi vur biri birine.
            //  Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap.

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


                Console.Write("dorduncu 6 reqemli ededi daxil et :");
                int eded4 = Convert.ToInt32(Console.ReadLine());

                eded = Math.Abs(eded);
                eded2 = Math.Abs(eded2);
                eded3 = Math.Abs(eded3);
                eded4 = Math.Abs(eded4);




                string ededStr = Convert.ToString(eded);
                string eded2Str = Convert.ToString(eded2);
                string eded3Str = Convert.ToString(eded3);
                string eded4Str = Convert.ToString(eded4);

                double birinciOn = eded * 1.0 * 10 / 100;
                double ikinciOn = eded2 * 1.0 * 10 / 100;
                double ucuncuOn = eded3 * 1.0 * 10 / 100;
                double dorduncuOn = eded4 * 1.0 * 10 / 100;

                double cemOn = birinciOn + ikinciOn + ucuncuOn + dorduncuOn;

                double birinciOnBesh = eded * 1.0 * 15 / 100;
                double ikinciOnBesh = eded2 * 1.0 * 15 / 100;
                double ucuncuOnBesh = eded3 * 1.0 * 15 / 100;
                double dorduncuOnBesh = eded4 * 1.0 * 15 / 100;

                double cemOnBesh = birinciOnBesh + ikinciOnBesh + ucuncuOnBesh + dorduncuOnBesh;
                double hasili = cemOn * cemOnBesh;
                double hasilinOnFaizi = hasili * 1.0 * 10 / 100;
                double son11 = hasili * 1.0 * 11 / 100;









                if (ededStr.Length == 6 && eded2Str.Length == 6 && eded3Str.Length == 6 && eded4Str.Length == 6)
                {
                    Console.WriteLine($"ededlerin 10 faizlerinin cemi = {cemOn}");
                    Console.WriteLine($"ededlerin 15 faizlerinin cemi = {cemOnBesh}");
                    Console.WriteLine($"Her iki cemin ({cemOn} ve {cemOnBesh}-in) hasili = {hasili}");
                    Console.WriteLine($"Hasilin ({hasili}) 10 faizi = {hasilinOnFaizi} ");
                    Console.WriteLine($"Alinan cavabin ({hasilinOnFaizi}-in) 11 faizi = {son11} ");


                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz ededler uygun deyil !");

                }
            }
        }
    }
}
