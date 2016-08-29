using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPage.MVC.Models
{
    public class EventLocation
    {
        public Event Event { get; set; }

        public Location Location { get; set; }

        public DateTime ScheduleTime { get; set; }

        public string Description { get; set; }
    }
}