using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPage.Domain.Entities
{
    public class Location
    {
        public Guid? LocationId { get; set; }

        public string Name { get; set; }

        public double Lat { get; set; }

        public double Lon { get; set; }

        public DateTime RegDate { get; set; }
    }
}
