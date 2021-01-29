using System;

namespace Metoder_opg_1._4__1._5__1._6_H1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4.	Lav en løkke der udskriver tallene mellem 1 og 10 i stigende rækkefølge: 1-2-3-4-5-6-7-8-9-10 
              5.Lav en løkke der udskriver tallene mellem 1 og 10 i faldende rækkefølge: 10 - 9 - 8 - 7 - 6 - 5 - 4 - 3 - 2 - 1
              6.Indtast et tal i konsollen og Lav en løkke der udskriver tallet, tæller 32 op og derefter 16 ned.*/

            UdskrivStigende(); //Metodekald
            TomLinje();
            UdskrivFaldende();
            TomLinje();
            BrugerInput("Indtast et tal");//Metodekald, Sender string med som påkrævet

            Console.ReadKey();//"Fastholder program
        }
        //Opretter metode til udskrivning af talrække stigende
        public static void UdskrivStigende()
        {
            for (int i = 1; i <= 10 ; i++)
            {
                Console.Write(i + " ");
            }

        }
        //Opretter metode til at udskrive en tom linje
        public static void TomLinje()
        {
            Console.WriteLine();
        }
        //Opretter metode til udskrivning af talrække faldende
        public static void UdskrivFaldende()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.Write(i + " ");
            }

        }
        //Opretter metode til at få et tal fra brugeren og udskrive det
        public static void BrugerInput(string question)
        {
            Console.WriteLine(question);
            int svar = int.Parse(Console.ReadLine());
                        
            for (int i = svar; i <= svar + 32; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; //ændre farve så det er letter at holde styr på i udskriften
                Console.WriteLine(i);
                if (i == svar + 32)//når i bliver brugerens indtastning + 32 (altså har kørt op) kører nedenstående
                {
                    for (int j = (svar + 32)-1; j > (svar + 32) - 16; j--)//kører indtil der talt 16 ned (dvs j er starttallet-16)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(j);
                    }

                }

            }
        }
    }
}
