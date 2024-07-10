using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        ICollection<Pokemon> GetPokemonByCountry(int countryId);
        bool CountryExists(int countryId);

    }
}
