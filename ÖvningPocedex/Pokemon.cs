namespace ÖvningPocedex;

internal class Pokemon
{
    int _currentForm;
    string _type;
    List<string> _allNames;

    public Pokemon(int currentForm, string type, List<string> allNames)
    {
        _currentForm = currentForm;
        _type = type;
        _allNames = allNames;
    }

    public int GetCurrentForm()
    {
        return _currentForm;
    }

    public string GetType()
    {
        return _type;
    }

    public List<string> GetAllNames()
    {
        return _allNames;
    }

    public int GetMaxEvolutions()
    {
        return _allNames.Count();
    }

    public bool Evolve()
    {
        if (_currentForm < GetMaxEvolutions())
        {
            _currentForm++;

            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetCurrentName()
    {
        return _allNames[_currentForm - 1];
    }

    public string GetInfo()
    {
        // Returnera en sträng med pokemonens nuvarande namn, och dess evolution
        return $"{_allNames[_currentForm - 1]} is a {_type} type Pokemon - Evolution: {_currentForm}/{GetMaxEvolutions()} ";
    }

}
