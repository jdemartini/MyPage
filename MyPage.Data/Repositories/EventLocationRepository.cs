using MyPage.Domain.Entities;
using MyPage.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPage.Data.Repositories
{
    public class EventLocationRepository : RepositoryBase<EventLocation>, IEventLocationRepository
    {
        public IEnumerable<EventLocation> FindByLocation(double lat, double lon)
        {
            return from events in db.EventsLocations where
                       events.ScheduleTime > DateTime.UtcNow.AddHours(-12) &&
                       events.Location.Lat == lat && events.Location.Lon == lon
                       select events;
            
        }
    }
}
