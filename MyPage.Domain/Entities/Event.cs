using System;
using System.Collections.Generic;

namespace MyPage.Domain.Entities
{
    public class Event : IEntity
    {
        public Guid? EventId { get; set; }

        public string Title { get; set; }

        public DateTime EventDate { get; set; }

        public string EventPlace { get; set; }

        public virtual List<Location> TransmissionPlaces { get; set; }

        public DateTime RegDate { get; set; }

        public void AddTransmissionPlace(Location newLocation)
        {
            if (this.TransmissionPlaces.Exists(l => l.LocationId.Equals(newLocation.LocationId)) == false)
                this.TransmissionPlaces.Add(newLocation);
        }
    }
}
 