using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPage.MVC.Models
{
    public class Event
    {
        public Guid? EventId{ get; set; }

        public string Title { get; set; }

        public DateTime EventDate { get; set; }

        public string EventPlace { get; set; }

        public IEnumerable<Location> TransmissionPlaces { get; set; } 

    }
}