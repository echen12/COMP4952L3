using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public static class SeedData
{
    // This is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var cities = GetCity();    // Get the list of cities
        var provinces = GetProvince(cities);  // Pass the cities to the GetProvince method

        modelBuilder.Entity<City>().HasData(cities);        // Seed City entities
        modelBuilder.Entity<Province>().HasData(provinces);  // Seed Province entities

    }

    public static List<City> GetCity()
    {
        List<City> cities = new List<City>() {
        new City {
            CityId = 1,
            CityName = "Vancouver",
            Population = 1000,
            ProvinceCode = "BC"
        },
        new City {
            CityId = 2,
            CityName = "Surrey",
            Population = 2000,
            ProvinceCode = "BC"
        },
        new City {
            CityId = 3,
            CityName = "Richmond",
            Population = 3000,
            ProvinceCode = "BC"
        },
        new City {
            CityId = 4,
            CityName = "Calgary",
            Population = 1000,
            ProvinceCode = "AB"
        },
        new City {
            CityId = 5,
            CityName = "Edmonton",
            Population = 2000,
            ProvinceCode = "AB"
        },
        new City {
            CityId = 6,
            CityName = "Red Deer",
            Population = 3000,
            ProvinceCode = "AB"
        },
        new City {
            CityId = 7,
            CityName = "Toronto",
            Population = 1000,
            ProvinceCode = "ON"
        },
        new City {
            CityId = 8,
            CityName = "Markham",
            Population = 2000,
            ProvinceCode = "ON"
        },
        new City {
            CityId = 9,
            CityName = "Richmond Hill",
            Population = 3000,
            ProvinceCode = "ON"
        }
    };

        return cities;
    }

    public static List<Province> GetProvince(List<City> cities)
    {
        List<Province> provinces = new List<Province>() {
            new Province {
            ProvinceCode = "BC",
            ProvinceName = "British Columbia"
        },
        new Province {
            ProvinceCode = "AB",
            ProvinceName = "Alberta"
        },
        new Province {
            ProvinceCode = "ON",
            ProvinceName = "Ontario"
        }
            // Define other provinces here similarly
        };

        return provinces;
    }
}