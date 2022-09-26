using APIteste.Models;

namespace APIteste
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get;} = new CitiesDataStore();

        public CitiesDataStore()
        {

            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with the big park",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id=1,
                            Name = "Central Park",
                            Description = "A Park"
                        },
                        new PointsOfInterestDto()
                        {
                            Id=2,
                            Name = "Statue of Liberty",
                            Description = "A Statue ",
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Lisbon",
                    Description = "The one",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id=3,
                            Name = "Vasco da gama",
                            Description = "A bridge"
                        },
                        new PointsOfInterestDto()
                        {
                            Id=4,
                            Name = "Praça do Comércio",
                            Description = "something ",
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id=5,
                            Name = "Eiffel tower",
                            Description = "A Tower"
                        },
                        new PointsOfInterestDto()
                        {
                            Id=6,
                            Name = "The Louvre",
                            Description = "The world largest museum ",
                        }
                    }
                }
            };
        }
    }
}
