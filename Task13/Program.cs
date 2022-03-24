using System;

namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  13) 5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir.
            //  5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.
            //  Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla.
            //  Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.
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

                Console.Write("birinci 5 reqemli ededi daxil et :");
                int eded = Convert.ToInt32(Console.ReadLine());

                Console.Write("ikinci 5 reqemli ededi daxil et :");
                int eded2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("3cu 5 reqemli ededi daxil et :");
                int eded3 = Convert.ToInt32(Console.ReadLine());


                Console.Write("birinci 3 reqemli ededi daxil et :");
                int eded4 = Convert.ToInt32(Console.ReadLine());

                Console.Write("ikinci 3 reqemli ededi daxil et :");
                int eded5 = Convert.ToInt32(Console.ReadLine());

                eded = Math.Abs(eded);
                eded2 = Math.Abs(eded2);
                eded3 = Math.Abs(eded3);
                eded4 = Math.Abs(eded4);
                eded5 = Math.Abs(eded5);




                string ededStr = Convert.ToString(eded);
                string eded2Str = Convert.ToString(eded2);
                string eded3Str = Convert.ToString(eded3);
                string eded4Str = Convert.ToString(eded4);
                string eded5Str = Convert.ToString(eded5);


                double birinciBesh = eded * 1.0 * 5 / 100;
                double ikinciBesh = eded2 * 1.0 * 5 / 100;
                double ucuncuBesh = eded3 * 1.0 * 5 / 100;

                double hasilBesh = birinciBesh * ikinciBesh * ucuncuBesh;

                double dorduncuUch = eded4 * 1.0 * 3 / 100;
                double beshinciUch = eded5 * 1.0 * 3 / 100;

                double cemUch = dorduncuUch + beshinciUch;

                double cemUchOnFaiz = cemUch*1.0*10/100;
                double hasilBeshOnFaiz = hasilBesh*1.0*10/100;
                double sonCem = cemUchOnFaiz+hasilBeshOnFaiz;









                if (ededStr.Length == 5 && eded2Str.Length == 5 && eded3Str.Length == 5 && eded4Str.Length == 3 && eded5Str.Length==3)
                {
                    Console.WriteLine($"5 reqemli ededlerin 5 faizlerinin hasili = {hasilBesh}");
                    Console.WriteLine($"3 reqemli ededlerin 3 faizlerinin cemi = {cemUch}");
                    Console.WriteLine($"Alinan iki ededin 10 faizinin ({hasilBeshOnFaiz} ve {cemUchOnFaiz}-in) cemi = {sonCem}");


                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz ededler uygun deyil !");

                }
            }
        }
    }
}
