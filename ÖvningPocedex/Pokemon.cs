namespace ÖvningPocedex
{
    public class Pokemon
    {
        string _pokemonName;
        string _pokemonPower;
        int _totalforms = 3;
        int _currentform = 1;

        public Pokemon(string pokemonName, string pokemonPower, int totalforms, int currentform)
        {
            _pokemonName = pokemonName;
            _pokemonPower = pokemonPower;
            _totalforms = totalforms;
            _currentform = currentform;
        }

        public string GetPokemonInfo()
        {
            return $"Name: {_pokemonName} - Power: {_pokemonPower}";

        }
    }
}
