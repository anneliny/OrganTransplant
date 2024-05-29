
namespace OrganTransplant
{
    class People
    {
        internal string Name;
        internal int KidneyNumber;
        internal int KidneyMatch;

        public People(string name, int kidneyNumber, int kidneyMatch)
        {
            Name = name;
            KidneyNumber = kidneyNumber;
            KidneyMatch = kidneyMatch;
        }

        internal void ShowPerson()
        {

            Console.Clear();

            
            
                Console.WriteLine($"Navn: {Name}");
                Console.WriteLine($"Antall nyrer: {KidneyNumber}");
                Console.WriteLine($"Match: {KidneyMatch}%");
                Console.WriteLine("Skriv - tilbake - om du ønsker å se på de andres info.");
                Console.WriteLine("Skriv - videre - om du har valgt personen du ønsker å bruke.");

            


        }


    }
}
