using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class CountryRepository : ICountryRegit adpository
    {
        public bool CountryExists(int countryId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Country> GetCountries()
        {
            throw new NotImplementedException();
        }

        public Country GetCountry(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Pokemon> GetPokemonByCountry(int countryId)
        {
            throw new NotImplementedException();
        }
    }
}
