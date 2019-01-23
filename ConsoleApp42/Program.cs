using System;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            //string angle = 45;
            //string vinkel;

            double hastighet = GetHastighet();
            double vinkel = GetVinkel();
            double vind = Getvind();
            Console.WriteLine(hastighet);
            Console.ReadKey();
           
            Console.WriteLine(vinkel);
            Console.ReadKey();
            Console.Write(vind);
            Console.ReadKey();
            
        }


         static double GetVinkel()
            {
                Console.Write("Skriv en vinkel");
                double vinkel = double.Parse(Console.ReadLine());
                return vinkel;

            }
        static double GetHastighet()
        {
            Console.Write("Skriv hastighet");
            double hastighet = double.Parse(Console.ReadLine());
            return hastighet;
        }
        static double Getvind()
         
        {
            Console.Write("Skriv vind");
            double vind = double.Parse(Console.ReadLine());
            return vind;
        }



    }
}
