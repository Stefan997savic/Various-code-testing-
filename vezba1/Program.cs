using System;

namespace vezba1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int broj = 5;
            //float realan = 4.4f;
            //double realan2 = 4.7;
            //char karakter = ';';
            //String tekst = "Ovo je neki tekst";
            //bool provera = true; // false;

            //ZADATAK 1
            //Console.Write("Unesite Vaše ime: ");
            //String unos = Console.ReadLine();
            //// Console.WriteLine("Zdravo, "+unos);
            //Console.WriteLine("Zdravo, {0} {0}",unos,"prezime");


            //ZADATAK 2
            Console.Write("Unesite neki tekst: ");
            String unos = Console.ReadLine();
            String promenjen = "";
            int i;
            for (i = 0; i < unos.Length; i++)
            {
                Console.Write(unos[i] + "=" + (int)unos[i] + " ");
               // unos[i]= unos[i]+1; - ne može, string je nepromenljiv tip
               promenjen += (char)(unos[i] + 1); // bey (char) ostaju brojevi
            }
            Console.WriteLine("\n"+promenjen);
        }
    }
}
