using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryOfAnOwner(int ownerId);
        ICollection<Owner> GetOwnerFromACountry(int countryId);
        bool CountryExists(int countryId);
        bool CreateCountry(Country country);
        bool Save();
    }
}
