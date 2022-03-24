using System;

namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  14) 6 dene 6 reqemli eded verilib.Evvel hamisini topla.
            //  Sonra I ve III ededi bir birine yapishdir ve bir eded al.
            //  I neticeden II neticeni cix.Alinan cavabin 10 % tap.
            //  Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11 % tap.
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

                Console.Write("1ci 6 reqemli ededi daxil et :");
                int eded = Convert.ToInt32(Console.ReadLine());

                Console.Write("2ci 6 reqemli ededi daxil et :");
                int eded2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("3cu 6 reqemli ededi daxil et :");
                int eded3 = Convert.ToInt32(Console.ReadLine());


                Console.Write("4cu 6 reqemli ededi daxil et :");
                int eded4 = Convert.ToInt32(Console.ReadLine());

                Console.Write("5ci 6 reqemli ededi daxil et :");
                int eded5 = Convert.ToInt32(Console.ReadLine());

                Console.Write("6ci 6 reqemli ededi daxil et :");
                int eded6 = Convert.ToInt32(Console.ReadLine());

                eded = Math.Abs(eded);
                eded2 = Math.Abs(eded2);
                eded3 = Math.Abs(eded3);
                eded4 = Math.Abs(eded4);
                eded5 = Math.Abs(eded5);
                eded6 = Math.Abs(eded6);




                string ededStr = Convert.ToString(eded);
                string eded2Str = Convert.ToString(eded2);
                string eded3Str = Convert.ToString(eded3);
                string eded4Str = Convert.ToString(eded4);
                string eded5Str = Convert.ToString(eded5);
                string eded6Str = Convert.ToString(eded6);


                int hamisininCemi = eded + eded2 + eded3 + eded4 + eded5 + eded6;

                string birVeIki = ededStr + eded2Str;
                long birVeIkiEded = Convert.ToInt64(birVeIki);

                long ilkNeticelerinFerqi = hamisininCemi - birVeIkiEded;
                double ilkNeticelerinFerqiOnfaizi = ilkNeticelerinFerqi * 1.0 * 10 / 100;

                double altiVeBeshElaveEt = ilkNeticelerinFerqiOnfaizi + eded5 + eded6;
                double altiVeBeshElaveEtOnBirFaiz = altiVeBeshElaveEt * 1.0 * 11 / 100;


                if (ededStr.Length == 6 && eded2Str.Length == 6 && eded3Str.Length == 6 && eded4Str.Length == 6 && eded5Str.Length == 6 && eded6Str.Length==6)
                {
                    Console.WriteLine($"hamisinin cemi = {hamisininCemi}");
                    Console.WriteLine($"birinci ({eded}) ve ikinci ({eded2}) ededleri yapisdiranda alinan eded = {birVeIkiEded}");
                    Console.WriteLine($"birinci neticeden ({hamisininCemi}) ikinci neticeni ({birVeIkiEded}) chixanda alinan eded = {ilkNeticelerinFerqi} veee hemin ferqin 10 faizi = {ilkNeticelerinFerqiOnfaizi}  ");
                    Console.WriteLine($"beshinci ({eded5}) ve altinci ({eded6}) ededi, hemin ferqin 10 faizinin ({ilkNeticelerinFerqiOnfaizi}) uzerine gelende alinan eded = {altiVeBeshElaveEt}");
                    Console.WriteLine($"Ve son olaraq alinan ededin ({altiVeBeshElaveEt}) 11 faizi = {altiVeBeshElaveEtOnBirFaiz}");
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz ededler uygun deyil !");

                }
            }
        }
    }
}
