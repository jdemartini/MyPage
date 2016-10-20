using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPage.Domain.Entities
{
    public class EventLocation : IEntity
    {
        public Guid? EventLocationId { get; set; } 

        public Event Event { get; set; }

        public Location Location { get; set; }

        public DateTime ScheduleTime { get; set; }

        public string Description { get; set; }

        public DateTime RegDate { get; set; }
    }
}
