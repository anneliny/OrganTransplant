
using OrganTransplant;

Game();
void Game()
{
    Console.WriteLine("I dette spillet skal du redde Bernt fra å dø, spillet blir forklart underveis.");
    Console.WriteLine("Trykk på en tast for å gå videre i spillet.");
    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("Det har vært en ulykke og Bernt ligger på sykehuset, han trenger en ny nyre!");
    Console.ReadKey();
    Console.WriteLine("Hans 3 fettere ankommer sykehuset for å se om de er en match og kan redde Bernt.");
    Console.ReadKey();
    Console.WriteLine("Skriv navnet til en av fetterne, for å se mer informasjon om de.");

    var person1 = new People("Kåre", 2, 100);
    var person2 = new People("Bjarne", 2, 50);
    var person3 = new People("Konrad", 1, 75);

    

    ShowPerson();

    void ShowPerson()
    {

        Console.WriteLine($"{person1.Name}, {person2.Name}, {person3.Name}");
        var inputInfo = Console.ReadLine();

        Console.Clear();

        if (inputInfo == person1.Name)
        {
            person1.ShowPerson();

        }
        else if (inputInfo == person2.Name)
        {

            person2.ShowPerson();

        }
        else if (inputInfo == person3.Name)
        {

            person3.ShowPerson();

        }


        var inputNext = Console.ReadLine();

        if (inputNext == "tilbake")
        {
            Console.Clear();
            ShowPerson();
        }
        else if (inputNext == "videre")
        {
            ChoosePerson();
        }

    }

    void ChoosePerson()
    {
        Console.Clear();
        Console.WriteLine("Har du funnet ut hvilken fetter du vil velge? Skriv navnet og se hvordan operasjonen gikk.");
        Console.WriteLine($"{person1.Name}, {person2.Name}, {person3.Name}");
        var inputChoice = Console.ReadLine();

        Console.Clear();

        if (inputChoice == person1.Name)
        {

            Console.WriteLine("Du bestemte deg for å bruke Kåre til å redde Bernt sitt liv.");
            Console.ReadKey();
            Console.WriteLine(
                "Operasjonen var vellykket, du reddet livet til Bernt og både han og Kåre er evig takknemmelige!");

        }
        else if (inputChoice == person2.Name)
        {

            Console.WriteLine("Du bestemte deg for å bruke Bjarne til å redde Bernt sitt liv.");
            Console.ReadKey();
            var randomChoice = new Random();
            int randomNumb = randomChoice.Next(0, 2);
            if (randomNumb == 0)
            {
                Console.WriteLine("Du skulle ikke tatt sjansen, både Bjarne og Bernt døde under operasjonen og du burde skamme deg.");
            }
            else if (randomNumb == 1)
            {
                Console.WriteLine("Det var virkelig flaks, for dette kunne gått veldig galt. Bernt og Bjarne lever og du får ikke sparken… Denne gangen…");
            }

        }
        else if (inputChoice == person3.Name)
        {

            Console.WriteLine("Du bestemte deg for å bruke Konrad til å redde Bernt sitt liv.");
            Console.ReadKey();
            Console.WriteLine("HVORFOR?!?! Du visste at Konrad bare hadde 1 nyre, men likevel brukte du han.. ");
            Console.WriteLine("Nå har både Konrad og Bernt dødd, bare fordi du ikke leste ordentlig…");
            Console.WriteLine("Eller kanskje du ikke brydde deg, din slemming!");

        }
    }
}

            





