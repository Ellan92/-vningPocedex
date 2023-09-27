// Välkomna användaren
// Fråga om användaren vill visa eller lägga till en pokemon
// Om användaren valde att lägga till...
// 1. Fråga om pokemon-namn
// 2. Fråga om specialkraft
// 3. Lägg till pokemonen i en lista
// Om användaren valde att visa alla pokemons...
// 1. Loopa över alla pokemons
// 2. Printa deras namn och specialkraft

//using ÖvningPocedex;

//bool isRunning = true;

//List<Pokemon> pokemonList = new();

//while (isRunning)
//{
//    Console.Clear();
//    WelcomeUser();
//    string response = AskForInput();

//    if (response == "a" || response == "A")
//    {
//        string pokemonName = AskForPokemonName();
//        string pokemonPower = AskForPokemonPower();

//        // Lägg till den nya pokemonen till listan 
//        Pokemon newPokemon = new(pokemonName, pokemonPower);
//        pokemonList.Add(newPokemon);
//    }
//    else if (response == "s" || response == "S")
//    {
//        DisplayAllPokemons();
//    }
//    else if (response == "e" || response == "E")
//    {
//        EvolvePokemon();
//    }
//}

//void EvolvePokemon(string pokemonName)
//{
//    foreach (var pokemon in pokemonList)
//    {
//        if (pokemon.GetPokemonName() == pokemonName)
//        {
//            pokemon.EvolvePokemon();

//        }
//        else
//        {
//            Console.WriteLine("That pokemon is not in the list!");

//            break;
//        }

//    }

//}

//void DisplayAllPokemons()
//{
//    foreach (Pokemon pokemon in pokemonList)
//    {
//        string pokemonInfo = pokemon.GetPokemonInfo();
//        Console.WriteLine(pokemonInfo);
//    }
//    Console.WriteLine("Thats all of them!");
//    Console.WriteLine("Press any key to continue...");
//    Console.ReadKey();
//}

//string AskForPokemonPower()
//{
//    Console.WriteLine("What is the pokemons power?");
//    Console.Write("Power: ");
//    string pokemonPower = Console.ReadLine();

//    return pokemonPower;
//}

//string AskForPokemonName()
//{
//    Console.WriteLine("What is the pokemons name?");
//    Console.Write("Name: ");
//    string pokemonName = Console.ReadLine();

//    return pokemonName;
//}

//string AskForInput()
//{
//    Console.WriteLine("Do you want to (a)dd a pokemon, (s)how all pokemons or (e)volve a pokemon?");
//    Console.Write("Reply: ");
//    string response = Console.ReadLine();

//    return response;
//}

//void WelcomeUser()
//{
//    Console.WriteLine("**********************");
//    Console.WriteLine("WELCOME TO THE POCEDEX");
//    Console.WriteLine("**********************");
//}



//GENOMGÅNG AV ÖVNINGEN

// Välkomna användaren
// Fråga användaren om den vill: lägga till, ta bort, evolva, eller visa alla pokemons
// Om användaren vill lägga till:
// Fråga om namn för alla evolutions
// Fråga om type
// Skapa en ny pokemon och lägg till den i listan
// Om användaren vill ta bort:
// Fråga användaren vilken pokemon den vill ta bort
// Ta bort den pokemonen
// Om användaren vill evolva:
// Fråga användaren vilken pokemon den vill evolva
// Öka currentForm på den pokemonen med 1
// Om användaren vill visa alla pokemons:
// Visa alla pokemons
// Fråga igen!

using ÖvningPocedex;

List<Pokemon> allPokemons = new();

bool isRunning = true;

while (isRunning)
{
    Console.Clear();
    WelcomeUser();
    string option = AskForOption();

    switch (option)
    {
        case "a":
        case "A":
            {
                // Add pokemon

                // Skapa en tom lista för alla namn

                List<string> pokemonNames = new();

                bool isAskingForNames = true;
                int form = 1;

                while (isAskingForNames)
                {
                    Console.Clear();
                    Console.WriteLine("ADDING POKEMON");
                    Console.WriteLine();
                    Console.WriteLine($"Add name for Pokemon evolution {form}");
                    Console.WriteLine("Type \"Done\" to complete");
                    Console.Write("Input: ");
                    string pokemonName = Console.ReadLine();

                    if (pokemonName.ToLower() != "done")
                    {
                        pokemonNames.Add(pokemonName);

                        form++;
                    }
                    else
                    {
                        // TODO: Check for empty pokemonNames list

                        isAskingForNames = false;
                    }
                }

                Console.WriteLine("What is the Pokemon type?");
                Console.Write("Type: ");
                string pokemonType = Console.ReadLine();

                Console.WriteLine("What is the current evolution?");
                Console.Write("Current evolution: ");

                // TODO: Make sure the input is a number
                int pokemonCurrentEvolution = int.Parse(Console.ReadLine());

                // Instantiera en ny pokemon med den inputtade datan
                Pokemon newPokemon = new(pokemonCurrentEvolution, pokemonType, pokemonNames);

                allPokemons.Add(newPokemon);

                Console.WriteLine("Pokemon added successfully!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                break;
            }
        case "r":
        case "R":
            {
                // Remove pokemon

                DisplayPokemons();

                Console.WriteLine("What pokemon do you want to remove?");
                Console.Write("Pokemon name: ");

                string pokemonName = Console.ReadLine();

                bool isFoundPokemon = false;

                for (int i = 0; i < allPokemons.Count(); i++)
                {
                    if (pokemonName.ToLower() == allPokemons[i].GetCurrentName().ToLower())
                    {
                        allPokemons.Remove(allPokemons[i]);

                        isFoundPokemon = true;
                    }
                }

                if (!isFoundPokemon)
                {
                    Console.WriteLine("No pokemon found!");
                    Console.WriteLine("Try again!");
                }
                else
                {
                    Console.WriteLine("Pokemon removed successfully!");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                break;
            }
        case "d":
        case "D":
            {
                // Display pokemon
                DisplayPokemons();

                break;
            }
        case "e":
        case "E":
            {
                // Evolve pokemon
                break;
            }
    }
}

void DisplayPokemons()
{
    foreach (Pokemon pokemon in allPokemons)
    {
        string pokemonInfo = pokemon.GetInfo();

        Console.WriteLine(pokemonInfo);
    }

    Console.WriteLine();
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

string AskForOption()
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("(A)dd, (R)emove, (D)isplay, (E)volve");
    Console.Write("Option: ");
    return Console.ReadLine();

}

void WelcomeUser()
{
    Console.WriteLine("| ************************************** |");
    Console.WriteLine("|   ********************************     |");
    Console.WriteLine("|      - WELCOME TO THE POKEDEX -        |");
    Console.WriteLine("|   ********************************     |");
    Console.WriteLine("| ************************************** |");
    Console.WriteLine("");
}
