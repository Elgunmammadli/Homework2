using System;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  15)*7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir.2 denesi 4 reqemlidir.
            //  2 denesi 5 reqemlidir. 1 denesi ise 6 reqemlidir.
            //  3 reqemli ededleri topla, sonra bunlarin ustune gel 4 reqemli ededlerin bir-birine
            //  vurulmasindan alinan cavabi.Sonra neticenin axirina 7 reqemini artir.
            //  Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
            //  Sonra neticeden cix 3 reqemli ededlerin bir-birine vurulmasindan alinan cavabin axirina 1
            //  artirilmish variantini.


            //  Sonra alinan cavabin ustune gel 6 reqemli ededi.
            //  Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
            //  Sonra alinan cavabin 18%-ni sonra 3%-ni sonra 1% tap.
            //  Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
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
                Console.WriteLine("7dene eded daxil etmelisen.");
                Console.Write("1ci 3 reqemli ededi daxil et :");
                int eded = Convert.ToInt32(Console.ReadLine());

                Console.Write("2ci 3 reqemli ededi daxil et :");
                int eded2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("1ci 4 reqemli ededi daxil et :");
                int eded3 = Convert.ToInt32(Console.ReadLine());


                Console.Write("2ci 4 reqemli ededi daxil et :");
                int eded4 = Convert.ToInt32(Console.ReadLine());

                Console.Write("1ci 5 reqemli ededi daxil et :");
                int eded5 = Convert.ToInt32(Console.ReadLine());

                Console.Write("2ci 5 reqemli ededi daxil et :");
                int eded6 = Convert.ToInt32(Console.ReadLine());

                Console.Write("6 reqemli ededi daxil et :");
                int eded7 = Convert.ToInt32(Console.ReadLine());

                eded = Math.Abs(eded);
                eded2 = Math.Abs(eded2);
                eded3 = Math.Abs(eded3);
                eded4 = Math.Abs(eded4);
                eded5 = Math.Abs(eded5);
                eded6 = Math.Abs(eded6);
                eded7 = Math.Abs(eded7);




                string ededStr = Convert.ToString(eded);
                string eded2Str = Convert.ToString(eded2);
                string eded3Str = Convert.ToString(eded3);
                string eded4Str = Convert.ToString(eded4);
                string eded5Str = Convert.ToString(eded5);
                string eded6Str = Convert.ToString(eded6);
                string eded7Str = Convert.ToString(eded7);
                string yeddi = "7";

                int ucReqemCemi = eded + eded2;
                int dortReqemCem = eded3 + eded4;
                int ucReqemHasil = eded * eded2;
                string bir = "1";
                string ucReqemHasilBir = ucReqemHasil + bir;
                int ucReqemHasilBirEded = Convert.ToInt32(ucReqemHasilBir);
                int dordReqemHasil = eded3 * eded4;
                int ucDortHasilCem = ucReqemCemi + dordReqemHasil;
                string yeddiElaveEt = ucDortHasilCem + yeddi;
                int yeddiElaveEtEded = Convert.ToInt32(yeddiElaveEt);
                int beshReqemCem = eded5 + eded6;
                int yeddiElaveEtTopla = beshReqemCem + yeddiElaveEtEded;
                int ferq1 = yeddiElaveEtTopla - ucReqemHasilBirEded;
                int altiReqemTopla = ferq1 + eded7;
                int ucDortReqemCem = ucReqemCemi + dortReqemCem;
                int ferq2 = altiReqemTopla - ucDortReqemCem;
                double ferq2Faiz = ferq2 * 1.0 * 18 * 3 * 1 / (100 * 100 * 100);




                if (ededStr.Length == 3 && eded2Str.Length == 3 && eded3Str.Length == 4 && eded4Str.Length == 4 && eded5Str.Length == 5 && eded6Str.Length == 5 && eded7Str.Length==6)
                {
                    Console.WriteLine($"3 reqemlilerin cemi({ucReqemCemi}) + 4reqemlilerin hasili({dordReqemHasil}) = {ucDortHasilCem}");
                    Console.WriteLine($"sonuna 7 elave edib({yeddiElaveEtEded}) ustune 5 reqemlilerin cemini({beshReqemCem}) gelende = {yeddiElaveEtTopla}");
                    Console.WriteLine($"hemin netice({yeddiElaveEtTopla}) - 3reqemlilerin hasilinin({ucReqemHasil}) sonuna 1 artirilmish varianti({ucReqemHasilBirEded}) = {ferq1}");
                    Console.WriteLine($"Ferqle({ferq1}) 6reqemli ededi({eded7}) toplayanda = {altiReqemTopla}");
                    Console.WriteLine($"Alinan cavabdan({altiReqemTopla}) cixirig 3 ve 4 reqemlilerin cemi({ucDortReqemCem}) = {ferq2}");
                    Console.WriteLine($"Hemin ferqin({ferq2}) birinci 18,alinan cavabin  3 ,ve onun da 1 faizi = {ferq2Faiz} ");
                    Console.WriteLine($"Son olaraq sonda alinan ededle({ferq2Faiz}) 5reqemli ededlerin cemi({beshReqemCem}) = {ferq2Faiz+beshReqemCem}");

                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz ededler uygun deyil !");

                }
            }
        }
    }
}
