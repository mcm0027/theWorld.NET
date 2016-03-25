﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    public class TheWorldContextSeedData
    {
        private WorldContext _context;

        public TheWorldContextSeedData(WorldContext context)
        {
            _context = context;
        }

        public void EnsureSeedData()
        {
            if (!_context.Trips.Any())
            {
                //Add new data
                var usTrip = new Trip()
                {
                    Name = "US Trip",
                    Create = DateTime.UtcNow,
                    UserName = "",
                    Stops = new List<Stop>()
                    {
                        new Stop() { Name = "Atlant, GA", Arrival = new DateTime(2014, 6, 4), Latitude = 33.14, Longitude = -84.38, Order = 0 },
                        new Stop() { Name = "New York, NY", Arrival = new DateTime(2014, 6, 9), Latitude = 40.71, Longitude = -74.00, Order = 1 },
                        new Stop() { Name = "Boston, MA", Arrival = new DateTime(2014, 7, 1), Latitude = 42.36, Longitude = -71.05, Order = 2 },
                        new Stop() { Name = "Chicago, WA", Arrival = new DateTime(2014, 7, 10), Latitude = 41.87, Longitude = -87.62, Order = 3 },
                        new Stop() { Name = "Atlanta, GA", Arrival = new DateTime(2014, 8, 23), Latitude = 33.14, Longitude = -84.38, Order = 4 }
                    }
                };

                _context.Trips.Add(usTrip);
                _context.Stops.AddRange(usTrip.Stops);

                var worldTrip = new Trip()
                {
                    Name = "World Trip",
                    Create = DateTime.UtcNow,
                    UserName = "",
                    Stops = new List<Stop>()
                    {
                        new Stop() { Name = "Atlant, GA", Arrival = new DateTime(2014, 6, 4), Latitude = 33.14, Longitude = -84.38, Order = 0 },
                        new Stop() { Name = "New York, NY", Arrival = new DateTime(2014, 6, 9), Latitude = 40.71, Longitude = -74.00, Order = 1 },
                        new Stop() { Name = "Boston, MA", Arrival = new DateTime(2014, 7, 1), Latitude = 42.36, Longitude = -71.05, Order = 2 },
                        new Stop() { Name = "Chicago, WA", Arrival = new DateTime(2014, 7, 10), Latitude = 41.87, Longitude = -87.62, Order = 3 },
                        new Stop() { Name = "Atlanta, GA", Arrival = new DateTime(2014, 8, 23), Latitude = 33.14, Longitude = -84.38, Order = 4 }

                    }
                };
                
                _context.Trips.Add(worldTrip);
                _context.Stops.AddRange(worldTrip.Stops);

                _context.SaveChanges();
            }
        }
    }
}
