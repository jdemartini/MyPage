﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPage.MVC.Models
{
    public class Location
    {
        public Guid? LocationId { get; set; }

        public string Name { get; set; }

        public double Lat { get; set; }

        public double Lon { get; set; }
    }
}