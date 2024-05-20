namespace Övning_1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Anställd> anställda = new List<Anställd>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till en ny anställd");
                Console.WriteLine("2. Visa samtliga anställda");
                Console.WriteLine("3. Avsluta");
                string val = Console.ReadLine();
                int anstNr = 0000;

                switch (val)
                {
                    case "1":
                        Console.Write("Förnamn?: ");
                        string fNamn = Console.ReadLine();

                        Console.Write("Efternamn?: ");
                        string eNamn = Console.ReadLine();

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
                            Console.WriteLine(anställd.ToString());
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
        public string fNamn { get; set; }
        public string eNamn { get; set; }
        public int anstNr { get; set; }
        public int lön { get; set; }


        public Anställd(string fNnamn, string eNnamn, int anstNr, int lön)
        {
            this.fNamn = fNamn;
            this.eNamn = eNamn;
            this.anstNr = anstNr;
            this.lön = lön;

        }

        public string toString()
        {
            return $"{fNamn} {eNamn}, Anställningsnummer: {anstNr}, Lön {lön}";
        }

    }
}
