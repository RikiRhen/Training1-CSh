/*
 * Uppgift 1: Vilka klasser bör ingå i programmet?
 *  En klass som hanterar anställda vore ju minimum. Jag hade gärna haft ett interface eller dylikt för Adress, som tar med adressen, postnummer, postort, stad etc och
 *  sedan använda detta som ett attribut för anställdas adress men hade inte hunnit med det.
 *  
 *  Uppgift 2: Klassen "Anställd" borde rimligtvis ha med sig förnamn och efternamn som minst. Jag personligen la till ett anställningsnummer och bakgrunden önskade även att lön läggs till.
 *  Så totalt 4 attribut: Förnamn, Efternamn, Anställningsnummer och Lön. Getters och setters till dessa men i dagsläget behövs de inte riktigt. Bra att ha för framtiden dock om t.ex. någon
 *  får en löneförhöjning eller ändrar namn.
 *  Klassen bör ju även ha en toString() metod inbyggt så att formateringen alltid blir korrekt när objekt av klassen ska printas ut.
 
*/
namespace Övning_1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            bool running = true;
            int identification = 0;

            while (running)
            {
                Console.WriteLine("Välj ett alternativ> ");
                Console.WriteLine("1. Lägg till en ny anställd");
                Console.WriteLine("2. Visa samtliga anställda");
                Console.WriteLine("3. Avsluta");
                string val = Console.ReadLine();
                
                switch (val)
                {
                    case "1":
                        string firstName;
                        do
                        {
                            Console.Write("Förnamn?> ");
                            firstName = Console.ReadLine();
                            if (string.IsNullOrEmpty(firstName))
                            {
                                Console.WriteLine("Förnamnet kan inte lämnas tomt. Försök igen!");
                            }
                        } while (string.IsNullOrWhiteSpace(firstName));


                        string familyName;
                        do
                        {
                            Console.Write("Efternamn?> ");
                            familyName = Console.ReadLine();
                            if (string.IsNullOrEmpty(familyName))
                            {
                                Console.WriteLine("Efternamnet kan inte lämnas tomt. Försök igen!");
                            }
                        } while (string.IsNullOrWhiteSpace(familyName));

                        Console.Write("Lön?> ");
                        int salary;
                        while (!int.TryParse(Console.ReadLine(), out salary))
                        {
                            Console.Write("Ogiltig lön, vänligen håll till heltal.");
                        }
                        identification++;

                        employees.Add(new Employee(firstName, familyName, identification, salary));
                        break;

                    case "2":
                        foreach (Employee employee in employees)
                        {
                            employee.toString();
                        }
                        break;

                    case "3":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val. Vänligen försök igen! \n");
                        break;

                }
            }

        }
    }

    class Employee
    {
        private string firstName { get; set; }
        private string familyName { get; set; }
        private int identification { get; set; }
        private int salary { get; set; }


        public Employee(string firstName, string familyName, int identification, int salary)
        {
            this.firstName = firstName;
            this.familyName = familyName;
            this.identification = identification;
            this.salary = salary;

        }
        
        public void toString()
        {
            Console.WriteLine ($"{firstName} {familyName}, Anställningsnummer: {identification}, Lön: {salary}");
        }

    }
}
