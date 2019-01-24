using System;

namespace ConsoleApp42
{
    class Program
    {

        private static int antal;


        static void Main(string[] args)
        {
            double hastighet = GetHastighet();
            double vinkel = Getvinkel();
            double vind = Getvind();
            double antal = Getantal();
            if (antal < 10)

                Console.WriteLine(hastighet);
            Console.ReadKey();

            Console.WriteLine(vinkel);
            Console.ReadKey();

            Console.Write(vind);
            Console.ReadKey();

        }

        private static double Getvind()
        {
            Console.Write("Skriv vind");
            double vind = double.Parse(Console.ReadLine());
            return vind;
        }

        private static double GetHastighet()
        {
            Console.Write("Skriv hastighet");
            double hastighet = double.Parse(Console.ReadLine());
            return hastighet;
        }

        private static double Getvinkel()
        {


            Console.Write("Skriv vinkel");
            double vinkel = double.Parse(Console.ReadLine());
            return vinkel;
        }

        private static double Getantal()
        {
            {
                antal = antal + 1;
                Console.Write("Antalet är" + antal);
                Console.ReadKey();
                return antal;
            }


            {

            } 
              else
            { }
            }
        }
    }




     





        
    



     
  



    


