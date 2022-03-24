using System;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  11) 4 dene 5 reqemli eded verilib.
            //  Her I ededin ustune III ededi gel.
            //  II ededin usutune IV eeddi gel.
            //  Sonra cavablari vur birbirine.
            //  Alinan neticeden III ededin 3 % -ni cix.

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


                Console.Write("dorduncu 5 reqemli ededi daxil et :");
                int eded4 = Convert.ToInt32(Console.ReadLine());

                eded = Math.Abs(eded);
                eded2 = Math.Abs(eded2);
                eded3 = Math.Abs(eded3);
                eded4 = Math.Abs(eded4);

                


                string ededStr = Convert.ToString(eded);
                string eded2Str = Convert.ToString(eded2);
                string eded3Str = Convert.ToString(eded3);
                string eded4Str = Convert.ToString(eded4);

                eded += eded3;
                eded2 += eded4;

                double ucuncuFaiz = eded3 * 1.0 * 3 / 100;
                int hasil = eded * eded2 * eded3 * eded4;

                
                double son = hasil-ucuncuFaiz;


                if (ededStr.Length == 5 && eded2Str.Length == 5 && eded3Str.Length == 5 && eded4Str.Length==5)
                {
                    Console.WriteLine($"Birinci ededin ustune 3cu ededi gelende : {eded}");
                    Console.WriteLine($"Ikinci ededin ustune 4cu ededi gelende : {eded2}");
                    Console.WriteLine($"ededlerin hasili : {hasil}");

                    Console.WriteLine($"hasili : {hasil} ile 3cu ededin 3 faizi :{ucuncuFaiz} nin ferqi: {son}");

                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz ededler uygun deyil !");

                }
            }
        }
    }
}
