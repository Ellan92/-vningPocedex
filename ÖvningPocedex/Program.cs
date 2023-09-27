// Välkomna användaren
// Fråga om användaren vill visa eller lägga till en pokemon
// Om användaren valde att lägga till...
// 1. Fråga om pokemon-namn
// 2. Fråga om specialkraft
// 3. Lägg till pokemonen i en lista
// Om användaren valde att visa alla pokemons...
// 1. Loopa över alla pokemons
// 2. Printa deras namn och specialkraft

using ÖvningPocedex;

bool isRunning = true;

List<Pokemon> pokemonList = new();

while (isRunning)
{
    Console.Clear();
    WelcomeUser();
    string response = AskForInput();

    if (response == "a" || response == "A")
    {
        string pokemonName = AskForPokemonName();
        string pokemonPower = AskForPokemonPower();

        // Lägg till den nya pokemonen till listan 
        Pokemon newPokemon = new(pokemonName, pokemonPower);
        pokemonList.Add(newPokemon);
    }
    else if (response == "s" || response == "S")
    {
        DisplayAllPokemons();
    }
    else if (response == "e" || response == "E")
    {
        EvolvePokemon();
    }
}

void EvolvePokemon(string pokemonName)
{
    foreach (var pokemon in pokemonList)
    {
        if (pokemon.GetPokemonName() == pokemonName)
        {
            pokemon.EvolvePokemon();

        }
        else
        {
            Console.WriteLine("That pokemon is not in the list!");

            break;
        }

    }

}

void DisplayAllPokemons()
{
    foreach (Pokemon pokemon in pokemonList)
    {
        string pokemonInfo = pokemon.GetPokemonInfo();
        Console.WriteLine(pokemonInfo);
    }
    Console.WriteLine("Thats all of them!");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

string AskForPokemonPower()
{
    Console.WriteLine("What is the pokemons power?");
    Console.Write("Power: ");
    string pokemonPower = Console.ReadLine();

    return pokemonPower;
}

string AskForPokemonName()
{
    Console.WriteLine("What is the pokemons name?");
    Console.Write("Name: ");
    string pokemonName = Console.ReadLine();

    return pokemonName;
}

string AskForInput()
{
    Console.WriteLine("Do you want to (a)dd a pokemon, (s)how all pokemons or (e)volve a pokemon?");
    Console.Write("Reply: ");
    string response = Console.ReadLine();

    return response;
}

void WelcomeUser()
{
    Console.WriteLine("**********************");
    Console.WriteLine("WELCOME TO THE POCEDEX");
    Console.WriteLine("**********************");
}
