using lesson65.Models;
using Microsoft.EntityFrameworkCore;

namespace lesson65.Services;

public class DbInitializer
{
    private readonly ModelBuilder _modelBuilder;

    public DbInitializer(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }
    public void Seed()
    {
        _modelBuilder.Entity<Country>().HasData(
            new Country(){Id = 1, Name = "Kyrgyzstan", OfficialName = "The Kyrgyz Republic", Region = "Asia", Population = 8000000, Capital = "Bishkek", Area = 200000},
            new Country(){Id = 2, Name = "USA", OfficialName = "United States of America", Region = "North America", Population = 330000000, Capital = "Washington", Area = 9833520},
            new Country(){Id = 3, Name = "Russia", OfficialName = "Russian Federation", Region = "Europe and Asia", Population = 150000000, Capital = "Moscow", Area = 17000000},
            new Country(){Id = 4, Name = "Portugal", OfficialName = "The Portuguese Republic", Region = "Europe", Population = 10200000, Capital = "Lisbon", Area = 92212},
            new Country(){Id = 5, Name = "Canada", OfficialName = "Dominion of Canada", Region = "Europe", Population = 38000000, Capital = "Ottawa", Area = 9984670},
            new Country(){Id = 6, Name = "Germany", OfficialName = "Federal Republic of Germany", Region = "Europe", Population = 83800000, Capital = "Berlin", Area = 357592},
            new Country(){Id = 7, Name = "France", OfficialName = "The French Republic", Region = "Europe", Population = 68000000, Capital = "Paris", Area = 551695},
            new Country(){Id = 8, Name = "Great Britain", OfficialName = "The United Kingdom of Great Britain and Northern Ireland", Region = "Europe", Population = 67000000, Capital = "London", Area = 209331},
            new Country(){Id = 9, Name = "Switzerland", OfficialName = "Swiss Confederation", Region = "Europe", Population = 8700000, Capital = "Bern", Area = 41285},
            new Country(){Id = 10, Name = "Norway", OfficialName = "The Kingdom of Norway", Region = "Europe", Population = 5500000, Capital = "Oslo", Area = 385207});
    }
}