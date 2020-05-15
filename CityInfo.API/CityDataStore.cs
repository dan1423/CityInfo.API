using CityInfo.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CityDataStore
    {
        public static CityDataStore Current { get; } = new CityDataStore();
        public List<CityDto> Cities { get; set; }

        public CityDataStore()
        {
            Cities = new List<CityDto>
            {
                new CityDto()
                {
                  Id=1,
                  Name = "New York City",
                  Description = "The city of cities",
                  PointsOfInterest = new List<PointOfInterestDto>()
                  {
                      new PointOfInterestDto()
                      {
                           Id = 1,
                          Name = "Central Park",
                          Description ="Cool park"
                      },
                      new PointOfInterestDto()
                      {
                           Id = 2,
                          Name = "Empire State Building",
                          Description ="Cool skyscraper"
                      }

                  }
                },
                new CityDto
                {
                     Id=2,
                  Name = "Chicago",
                  Description = "Windy city"
                }
            };
        }
    }
}
