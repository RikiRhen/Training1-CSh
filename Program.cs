﻿namespace Övning_1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Anställd> anställda = new List<Anställd>();
            bool running = true;
            int anstNr = 0;

            while (running)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till en ny anställd");
                Console.WriteLine("2. Visa samtliga anställda");
                Console.WriteLine("3. Avsluta");
                string val = Console.ReadLine();
                
                switch (val)
                {
                    case "1":
                        string fNamn;
                        do
                        {
                            Console.Write("Förnamn?: ");
                            fNamn = Console.ReadLine();
                            if (string.IsNullOrEmpty(fNamn))
                            {
                                Console.WriteLine("Förnamnet kan inte lämnas tomt. Försök igen!");
                            }
                        } while (string.IsNullOrWhiteSpace(fNamn));


                        string eNamn;
                        do
                        {
                            Console.Write("Efternamn?: ");
                            eNamn = Console.ReadLine();
                            if (string.IsNullOrEmpty(eNamn))
                            {
                                Console.WriteLine("Efternamnet kan inte lämnas tomt. Försök igen!");
                            }
                        } while (string.IsNullOrWhiteSpace(eNamn));

                        Console.Write("Lön?: ");
                        int lön;
                        while (!int.TryParse(Console.ReadLine(), out lön))
                        {
                            Console.Write("Ogiltig lön, vänligen håll till heltal.");
                        }
                        anstNr++;

                        anställda.Add(new Anställd(fNamn, eNamn, anstNr, lön));
                        break;

                    case "2":
                        foreach (Anställd anställd in anställda)
                        {
                            anställd.toString();
                        }
                        break;

                    case "3":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val. Vänligen försök igen!\n");
                        break;

                }
            }

        }
    }

    public class Anställd
    {
        private string fNamn { get; set; }
        private string eNamn { get; set; }
        private int anstNr { get; set; }
        private int lön { get; set; }


        public Anställd(string fNamn, string eNamn, int anstNr, int lön)
        {
            this.fNamn = fNamn;
            this.eNamn = eNamn;
            this.anstNr = anstNr;
            this.lön = lön;

        }

        public void toString()
        {
            Console.WriteLine ($"{fNamn} {eNamn}, Anställningsnummer: {anstNr}, Lön {lön}");
        }

    }
}
